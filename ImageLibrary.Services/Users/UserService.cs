using ImageLibrary.Entities.Models.Auths;
using ImageLibrary.MongoDB.Repository;
using ImageLibrary.Services.Users.Dto;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImageLibrary.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IMongoRepository<UserEntity, ObjectId> _repository;

        public UserService(IMongoRepository<UserEntity, ObjectId> repository)
        {
            _repository = repository;
        }

        public Task<UserEntity> AddUser(RegisterRequest item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserEntity GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
