using CrusherSoftwareAPI.Data;
using CrusherSoftwareAPI.IRepository;
using CrusherSoftwareAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CrusherSoftwareAPI.Repository
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly CrusherDbContext _context;

        public CustomerRepository(CrusherDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers.Where(c => c.IsActive == true).ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers.Where(c => c.CustomerId == id && c.IsActive == true).FirstOrDefaultAsync();
        }

        public async Task AddAsync(Customer customer)
        {
            customer.CreatedDate = DateTime.UtcNow;
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer customer)
        {
            customer.UpdatedDate = DateTime.UtcNow;
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                customer.IsActive = false;
                _context.Customers.Update(customer);
                //_context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }
    }
}
