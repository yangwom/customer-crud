using CustomerCrud.Core;
using CustomerCrud.Repositories;
using CustomerCrud.Requests;

namespace CustomerCrud.Test;

public class CustomersControllerTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;
    private readonly Mock<ICustomerRepository> _repositoryMock;

    public CustomersControllerTest(WebApplicationFactory<Program> factory)
    {
        _repositoryMock = new Mock<ICustomerRepository>();

        _client = factory.WithWebHostBuilder(builder =>
        {
            builder.ConfigureServices(services =>
            {
                services.AddScoped<ICustomerRepository>(st => _repositoryMock.Object);
            });
        }).CreateClient();
    }

    [Fact]
    public async Task GetAllTest()
    {
        var customer = AutoFaker.Generate<Customer>(3);
        _repositoryMock.Setup(c => c.GetAll()).Returns(customer);

        var response = await _client.GetAsync("/controller");
        var data = await response.Content.ReadFromJsonAsync<IEnumerable<Customer>>();
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        data.Should().BeEquivalentTo(customer);
    }

    [Fact]
    public async Task GetByIdTest()
    {
        var customer = AutoFaker.Generate<Customer>(3);
        _repositoryMock.Setup(c => c.GetById(1)).Returns(customer[0]);
        var response = await _client.GetAsync("/controller/1");
        var data = await response.Content.ReadFromJsonAsync<IEnumerable<Customer>>();
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        data.Should().BeEquivalentTo(customer);

    }

    [Fact]
    public async Task CreateTest()
    {
        var customer = AutoFaker.Generate<CustomerRequest>();
        _repositoryMock.Setup(c => c.Create(null)).Returns(true);
        _repositoryMock.Setup(c => c.GetNextIdValue()).Returns(1);

        var response = await _client.PostAsJsonAsync("/controller", customer);
        var data = await response.Content.ReadFromJsonAsync<Customer>();

        response.StatusCode.Should().Be(HttpStatusCode.Created);
        data.Should().BeEquivalentTo(customer);
    }

    [Fact]
    public async Task UpdateTest()
    {
    var customerRequest = AutoFaker.Generate<CustomerRequest>();
    _repositoryMock.Setup(c => c.Update(1, It.IsAny<Customer>())).Returns(true);

    var response = await _client.PutAsJsonAsync("/controller/1", customerRequest);
    var content = await response.Content.ReadAsStringAsync();

    response.StatusCode.Should().Be(HttpStatusCode.OK);
    content.Should().Be("Customer 1 updated");
    }

    [Fact]
    public async Task DeleteTest()
    {
    _repositoryMock.Setup(c => c.Delete(It.IsAny<int>())).Returns(true);

    var response = await _client.DeleteAsync("/controller/1");

    response.StatusCode.Should().Be(HttpStatusCode.NoContent);

    _repositoryMock.Verify(c => c.Delete(It.IsAny<int>()), Times.Once);
    }
}