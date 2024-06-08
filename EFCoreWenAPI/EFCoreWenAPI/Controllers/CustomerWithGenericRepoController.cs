using EFCoreWenAPI.Models;
using EFCoreWenAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreWenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerWithGenericRepoController : ControllerBase
    {
        private readonly EfdbFirstContext _context;

        private readonly IGenericRepository<Customer> _repo;
        public CustomerWithGenericRepoController(IGenericRepository<Customer> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repo.GetAllAsync();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _repo.GetByIdAsync(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            await _repo.InsertAsync(customer);
            await _repo.SaveAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(Customer customer)
        {
            await _repo.UpdateAsync(customer);
            await _repo.SaveAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(int id)
        {
            await _repo.DeleteAsync(id);
            await _repo.SaveAsync();
            return Ok();
        }
    }
}
