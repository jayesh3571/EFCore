using EFCoreWenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWenAPI.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly EfdbFirstContext _context;
        public CustomerRepository(EfdbFirstContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(int id)
        {
           var cstid = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
           if(cstid != null)
            {
                _context.Customers.Remove(cstid);
                
            }
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
           return await _context.Customers.ToListAsync();
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await _context.Customers.Where(x=>x.Id == id).FirstOrDefaultAsync();
        }

        public async Task InsertAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer customer)
        {
             _context.Customers.Update(customer);
            
        }
    }
}
