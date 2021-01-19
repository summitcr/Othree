using Othree.Data.Models;
using Othree.DBServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Othree.Test
{
    public class CustomerServiceFake : ICustomerService
    {
        private readonly List<Customer> _customers;

        public CustomerServiceFake()
        {
            _customers = new List<Customer>()
            {
                new Customer(){
                    Id = 1,
                    Email = "valeringustavo",
                    Birth = DateTime.Now,
                    Lastname = "valerin",
                    Name ="Gustavo",
                    Phonenumber="14147"
                    

                },
                new Customer(){
                       Id = 2,
                    Email = "valerinalberto",
                    Birth = DateTime.Now,
                    Lastname = "valerin",
                    Name ="Alberto",
                    Phonenumber="66589555"
                },
                new Customer(){
                 Id = 2,
                    Email = "valerinalberto",
                    Birth = DateTime.Now,
                    Lastname = "valerin",
                    Name ="Alberto",
                    Phonenumber="66589555"
                }
              

            };
        }
        public async Task<Customer> AddCustomerAsync(Customer newCustomer)
        {
            var mytask = await Task.Run(() => newCustomer);
            return mytask;
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            var mytask = await Task.Run(() => _customers);
            return mytask;
        }

        public Task<Customer> GetCustomerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
