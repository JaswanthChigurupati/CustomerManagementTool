using CustomerManagement.Api.Interfaces.Repositories;
using CustomerManagement.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_repository.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer = _repository.GetById(id);
            if (customer == null) return NotFound();
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            _repository.Add(customer);
            return CreatedAtAction(nameof(GetById), new { id = customer.Id }, customer);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Customer customer)
        {
            if (id != customer.Id) return BadRequest();
            _repository.Update(customer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return NoContent();
        }
    }

}
