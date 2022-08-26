using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IResult Register(UserForAuthDto userForAuthDto);
        IResult Login(UserForAuthDto userForAuthDto);
        IResult ChangePassword(ChangePasswordDto changePasswordDto);
        IResult ChangeUserName(ChangeUserNameDto changeUserNameDto);
        IResult UserExists(string userName);
    }
}
