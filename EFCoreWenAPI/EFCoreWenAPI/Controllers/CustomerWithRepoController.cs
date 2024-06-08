using EFCoreWenAPI.Models;
using EFCoreWenAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreWenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerWithRepoController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerWithRepoController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var result = await _customerRepository.GetAllAsync();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _customerRepository.GetByIdAsync(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {            
            await _customerRepository.InsertAsync(customer);
            await _customerRepository.SaveAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(Customer customer)
        {
            await _customerRepository.UpdateAsync(customer);
            await _customerRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(int id)
        {
            await _customerRepository.DeleteAsync(id);
            await _customerRepository.SaveAsync();
            return Ok();
        }
    }
}
