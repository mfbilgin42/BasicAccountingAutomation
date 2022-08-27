using Business.Abstract;
using Business.Contants;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Entities.Dtos;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserService _userService;

        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }

        public IResult ChangePassword(ChangePasswordDto changePasswordDto)
        {
            byte[] passwordHash, passwordSalt;
            User userToCheck = _userService.GetByUserName(changePasswordDto.UserName).Data;
            if (userToCheck == null)
            {
                return new ErrorResult(Messages.UserNameError);
            }
            if (!HashingHelper.VerifyPasswordHash(changePasswordDto.OldPassword,userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorResult(Messages.PasswordError);
            }
            if (changePasswordDto.OldPassword == changePasswordDto.NewPassword)
            {
                return new ErrorResult(Messages.PasswordsSame);
            }
            HashingHelper.CreatePasswordHash(changePasswordDto.NewPassword,out passwordHash,out passwordSalt);
            userToCheck.PasswordHash = passwordHash;
            userToCheck.PasswordSalt = passwordSalt;
            _userService.Update(userToCheck);
            return new SuccessResult(Messages.PasswordChanged);
        }

        public IResult ChangeUserName(ChangeUserNameDto changeUserNameDto)
        {
            User userToCheck = _userService.GetByUserName(changeUserNameDto.OldUserName).Data;
            var result = UserExists(changeUserNameDto.OldUserName);
            if (userToCheck == null)
            {
                return new ErrorResult(Messages.UserNameError);
            }
            if (!HashingHelper.VerifyPasswordHash(changeUserNameDto.Password,userToCheck.PasswordHash,userToCheck.PasswordSalt))
            {
                return new ErrorResult(Messages.PasswordError);
            }
            if (changeUserNameDto.OldUserName == changeUserNameDto.NewUserName)
            {
                return new ErrorResult(Messages.UserAlreadyExist);
            }
            userToCheck.UserName = changeUserNameDto.NewUserName;
            _userService.Update(userToCheck);
            return new SuccessResult(Messages.UserNameChanged);
        }

        public IResult Login(UserForAuthDto userForAuthDto)
        {
            User userToCheck = _userService.GetByUserName(userForAuthDto.UserName).Data;
            if (userToCheck == null)
            {
                return new ErrorResult(Messages.UserNameError);
            }
            if (!HashingHelper.VerifyPasswordHash(userForAuthDto.Password,userToCheck.PasswordHash,userToCheck.PasswordSalt))
            {
                return new ErrorResult(Messages.PasswordError);
            }
            return new SuccessResult(Messages.LoginSuccessful);
        }

        public IResult Register(UserForAuthDto userForAuthDto)
        {
            IResult businessRuleResult = BusinessRules.Run(CheckIfUserNameLengthLessThanThree(userForAuthDto.UserName));

            if (businessRuleResult != null)
            {
                return businessRuleResult;
            }
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForAuthDto.Password,out passwordHash, out passwordSalt);
            User user = new User
            {
                UserName = userForAuthDto.UserName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };
            var result = _userService.Add(user);
            return new SuccessResult(result.Message);
        }

        public IResult UserExists(string userName)
        {
            User userToCheck = _userService.GetByUserName(userName).Data;
            if (userToCheck != null)
            {
                return new ErrorResult(Messages.UserAlreadyExist);
            }
            return new SuccessResult();
        }
        private IResult CheckIfUserNameLengthLessThanThree(string userName)
        {
            if (userName.Length <= 3)
            {
                return new ErrorResult(Messages.UserNameLengthMustBeMoreThanThree);
            }
            return new SuccessResult();
        }
    }
}