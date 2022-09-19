using Microsoft.AspNetCore.Mvc;
using CustomerCrud.Core;
using CustomerCrud.Requests;
using CustomerCrud.Repositories;

namespace CustomerCrud.Controllers;
[ApiController]
[Route("/controller")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerRepository? _customerRepository;

    public CustomerController(ICustomerRepository customer)
    {
        _customerRepository = customer;
    }

    [HttpGet]
    public ActionResult Get()
    {
        return Ok(_customerRepository?.GetAll());
    }

    [HttpGet]
    [Route("{id}")]

    public ActionResult GetById(int id)
    {
        var DataCustomer = _customerRepository?.GetById(id);

        if(DataCustomer == null)
        {
            return NotFound("Not fount");
        }

        return Ok(DataCustomer);
    }
}
