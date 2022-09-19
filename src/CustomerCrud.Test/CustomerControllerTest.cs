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
        throw new NotImplementedException();
    }

    [Fact]
    public async Task CreateTest()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public async Task UpdateTest()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public async Task DeleteTest()
    {
        throw new NotImplementedException();
    }
}