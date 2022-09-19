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

    [HttpGet("{id}", Name = "GetById")]

    public ActionResult GetById(int id)
    {
        var DataCustomer = _customerRepository?.GetById(id);

        if(DataCustomer == null)
        {
            return NotFound("Not fount");
        }

        return Ok(DataCustomer);
    }

    [HttpPost]
    public ActionResult Create(CustomerRequest customer)
    {
        var Created = new Customer(_customerRepository!.GetNextIdValue(), customer);
        var DataCustomer = _customerRepository.Create(Created);
         if(!DataCustomer)
         {
            BadRequest("bad requst");
         }

        return CreatedAtAction("GetById", new { id = Created.Id }, customer);
    }
}
