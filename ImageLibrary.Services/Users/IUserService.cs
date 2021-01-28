using ImageLibrary.Entities.Models.Auths;
using ImageLibrary.Services.Users.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImageLibrary.Services.Users
{
    public interface IUserService
    {
        public Task<IEnumerable<UserEntity>> GetAllUsers();
        public UserEntity GetUser(string id);
        public Task<UserEntity> GetUserAsync(string id);
        public Task<UserEntity> GetUserByEmailAsync(string email);
        public Task<UserEntity> AddUser(RegisterRequest item);

    }
}
