using Othree.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Othree.DBServices.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<Customer> GetCustomerByIdAsync(int id);

        Task<List<Customer>> GetAllCustomersAsync();
    }
}