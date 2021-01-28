using ImageLibrary.Entities.Models.Auths;
using ImageLibrary.Services.Auths.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImageLibrary.Services.Auths
{
    public interface IAuthService
    {
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        Task<IEnumerable<UserEntity>> GetAllUsers();


    }
}
