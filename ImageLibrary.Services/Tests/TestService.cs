using ImageLibrary.Entities;
using ImageLibrary.MongoDB.Repository;
using ImageLibrary.Services.Tests.Dto;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;



namespace ImageLibrary.Services.Tests
{
    public class TestService : ITestService
    {
        private readonly IMongoRepository<AppUsers, ObjectId> _repository;

        public TestService(IMongoRepository<AppUsers, ObjectId> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<AppUsers>> GetAll()
        {
            try
            {
                var result = await _repository.GetAllListAsync();
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
