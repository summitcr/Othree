using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Othree.Data.Models;
using Othree.DBServices.Interfaces;

namespace Othree.DBServices.Repositories
{ 
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(postgresContext _context) : base(_context)
        {
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await GetAll().ToListAsync();
        }

      
}
}