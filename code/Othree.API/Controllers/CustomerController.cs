using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Othree.API.DTOs;
using Othree.Data.Models;
using Othree.DBServices.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Othree.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            try
            { 

                var customers = await _customerService.GetAllCustomersAsync();
                var response =  _mapper.Map<List<CustomerDTO>>(customers);

                return Ok(response);
            }
            catch (Exception ex)
            {
                var exc = ex.Message;

                return BadRequest();
            }
           
        }
       

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

       
        [HttpPost]
        public async Task<IActionResult> PostAsync(CustomerDTO model)
        {
            try
            {
                var customer = _mapper.Map<Customer>(model);
                var fesponse = await _customerService.AddCustomerAsync(customer);

                return Ok(fesponse);

            }
            catch (Exception ex)
            {
                var exc = ex.Message;

                return BadRequest();
            }
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
