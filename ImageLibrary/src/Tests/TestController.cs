using ImageLibrary.Entities;
using ImageLibrary.Entities.Models.Auths;
using ImageLibrary.Services.Tests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageLibrary.Host.src.Tests
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet()]
        public async Task<IEnumerable<AppUsers>> GetAll()
        {
            var data = await _testService.GetAll();
            return data;
        }

    }
}
