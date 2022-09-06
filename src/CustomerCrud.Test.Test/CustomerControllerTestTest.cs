namespace CustomerCrud.Test.Test;

public class CustomerControllerTestTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly CustomersControllerTest _instance;

    public CustomerControllerTestTest(WebApplicationFactory<Program> factory)
    {
        _instance = new CustomersControllerTest(factory);
    }

    [Trait("Category", "1 - GetAllTest deve testar método GetAll do CustomerController")]
    [Fact(DisplayName = "1 - GetAllTest deve testar método GetAll do CustomerController")]
    public async void TestGetAllTest()
    {
        Func<Task> act = () => _instance.GetAllTest();

        await act.Should().NotThrowAsync<NotImplementedException>();
        await act.Should().NotThrowAsync<XunitException>();
    }
}
public class CustomerControllerTestTest2 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly CustomersControllerTest _instance;

    public CustomerControllerTestTest2(WebApplicationFactory<Program> factory)
    {
        _instance = new CustomersControllerTest(factory);
    }

    [Trait("Category", "2 - GetByIdTest deve testar método GetById do CustomerController")]
    [Fact(DisplayName = "2 - GetByIdTest deve testar método GetById do CustomerController")]
    public async void TestGetByIdTest()
    {
        Func<Task> act = () => _instance.GetByIdTest();

        await act.Should().NotThrowAsync<NotImplementedException>();
        await act.Should().NotThrowAsync<XunitException>();
    }
}
public class CustomerControllerTestTest3 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly CustomersControllerTest _instance;

    public CustomerControllerTestTest3(WebApplicationFactory<Program> factory)
    {
        _instance = new CustomersControllerTest(factory);
    }
    [Trait("Category", "3 - CreateTest deve testar método Create do CustomerController")]
    [Fact(DisplayName = "3 - CreateTest deve testar método Create do CustomerController")]
    public async void TestCreateTest()
    {
        Func<Task> act = () => _instance.CreateTest();

        await act.Should().NotThrowAsync<NotImplementedException>();
        await act.Should().NotThrowAsync<XunitException>();
    }
}
public class CustomerControllerTestTest4 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly CustomersControllerTest _instance;

    public CustomerControllerTestTest4(WebApplicationFactory<Program> factory)
    {
        _instance = new CustomersControllerTest(factory);
    }
    [Trait("Category", "4 - UpdateTest deve testar método Update do CustomerController")]
    [Fact(DisplayName = "4 - UpdateTest deve testar método Update do CustomerController")]
    public async void TestUpdateTest()
    {
        Func<Task> act = () => _instance.UpdateTest();

        await act.Should().NotThrowAsync<NotImplementedException>();
        await act.Should().NotThrowAsync<XunitException>();
    }
}
public class CustomerControllerTestTest5 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly CustomersControllerTest _instance;

    public CustomerControllerTestTest5(WebApplicationFactory<Program> factory)
    {
        _instance = new CustomersControllerTest(factory);
    }
    [Trait("Category", "5 - DeleteTest deve testar método Delete do CustomerController")]
    [Fact(DisplayName = "5 - DeleteTest deve testar método Delete do CustomerController")]
    public async void TestDeleteTest()
    {
        Func<Task> act = () => _instance.DeleteTest();

        await act.Should().NotThrowAsync<NotImplementedException>();
        await act.Should().NotThrowAsync<XunitException>();
    }
}