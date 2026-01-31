using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Services.Interface;

namespace BusinessLogic.Services
{
    public class UserService : IUserService
    {
        //private readonly IUserRepository _userRepo;

        //public UserService(IUserRepository userRepo)
        //{
        //    _userRepo = userRepo;
        //}

        //public LoginResponse Login(LoginRequest request)
        //{
        //    var user = _userRepo.GetByEmail(request.Email);

        //    if (user == null)
        //        throw new Exception("User not found");

        //    return new LoginResponse
        //    {
        //        UserId = user.Id,
        //        Token = "fake-jwt"
        //    };
        //}
    }

}
