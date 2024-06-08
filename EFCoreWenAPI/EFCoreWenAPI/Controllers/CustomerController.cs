
using EFCoreWenAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {   
        private readonly EfdbFirstContext _firstContext;
        public CustomerController(EfdbFirstContext context)
        {
            _firstContext = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllBrands()
        {
            var result = _firstContext.Customers.ToList();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetailById(int id)
        {
            var result = _firstContext.Customers.Where(x=>x.Id == id).ToList();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer([Bind("Name","Mobile")] Customer customer)
        {
            _firstContext.Add(customer);
            await _firstContext.SaveChangesAsync();
            return Ok();
            
        }
        [HttpPut]
        public async Task<IActionResult> UpodateCustomer(int id ,[Bind("Id","Name", "Mobile")] Customer customer)
        {
           
            _firstContext.Update(customer);
            await _firstContext.SaveChangesAsync();
            return Ok();

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCustomer(int id)
        {

            var res = await _firstContext.Customers.FindAsync(id);
            _firstContext.Remove(res);
            await _firstContext.SaveChangesAsync();
            return Ok();

        }
    }
}
