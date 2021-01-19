using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Othree.API.Controllers;
using Othree.API.DTOs;
using Othree.API.Utils;
using Othree.DBServices.Interfaces;
using Othree.DBServices.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Othree.Test
{
    public class CustomerServiceTest
    {
        CustomerController _controller;
        ICustomerService _service;
        private static IMapper _mapper;

       
        public CustomerServiceTest()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapping());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            _mapper = mapper;

            _service = new CustomerServiceFake();
            _controller = new CustomerController(_service, _mapper);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetAsync();
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Acts
            var okResult = _controller.GetAsync().Result as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<CustomerDTO>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void Add_InvalidObjectPassed_ReturnsBadRequest()
        {
            // Arrange
            var phoneNumerMissingItem =  new CustomerDTO()
            {
                Email = "valeringustavo",
                Birth = DateTime.Now,
                Lastname = "valerin",
                Name = "Gustavo",
                Phonenumber = "14147"


            };
             _controller.ModelState.AddModelError("Phonenumber", "Required");
            // Act
            var badResponse = _controller.PostAsync(phoneNumerMissingItem).Result;
            // Assert
            Assert.IsType<BadRequestObjectResult>(badResponse);
        }
        [Fact]
        public void Add_ValidObjectPassed_ReturnsCreatedResponse()
        {
            // Arrange
            var phoneNumerItem = new CustomerDTO()
            {
                Email = "valeringustavo",
                Birth = DateTime.Now,
                Lastname = "valerin",
                Name = "Gustavo",
                Phonenumber = "14147"


            };
            // Act
            var createdResponse = _controller.PostAsync(phoneNumerItem).Result;
            // Assert
            Assert.IsType<OkObjectResult>(createdResponse);
        }

    }
}
