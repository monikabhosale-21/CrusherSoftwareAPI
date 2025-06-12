using CrusherSoftwareAPI.IRepository;
using CrusherSoftwareAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrusherSoftwareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("GetAllCustomer")]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _repository.GetAllAsync();
            return Ok(new { message = "Customers retrieved successfully.", data = customers });
        }
          

        [HttpGet("GetCustomerById")]
        public async Task<IActionResult> GetById(int id)
        {
            var customer = await _repository.GetByIdAsync(id);
            if (customer == null)
                return NotFound(new { message = "Customer not found." });

            return Ok(new { message = "Customer retrieved successfully.", data = customer });
        }

        [HttpPost("Save")]
        public async Task<IActionResult> Create([FromBody] Customer customer)
        {
            await _repository.AddAsync(customer);
            return CreatedAtAction(nameof(GetById), new { id = customer.CustomerId }, new
            {
                message = "Customer created successfully.",
                data = customer
            });
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Customer customer)
        {
            if (id != customer.CustomerId)
                return BadRequest(new { message = "Customer ID mismatch." });

            await _repository.UpdateAsync(customer);
            return Ok(new { message = "Customer updated successfully." });
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok(new { message = "Customer deleted successfully." });
        }

        [HttpGet("GetCustomerName")]
        public async Task<IActionResult> GetCustomerName()
        {
            var customers = await _repository.GetCustomerName();
            return Ok(new { message = "Customers Name retrieved successfully.", data = customers });
        }


        [HttpGet("GetCityName")]
        public async Task<IActionResult> GetCityName()
        {
            var city = await _repository.GetCityName();
            return Ok(new { message = "Customers Name retrieved successfully.", data = city });
        }

    }
}
