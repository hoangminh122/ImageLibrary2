using ImageLibrary.Entities;
using ImageLibrary.Services.Tests.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImageLibrary.Services.Tests
{
    public interface ITestService
    {
        public Task<IEnumerable<AppUsers>> GetAll();
    } 
}
