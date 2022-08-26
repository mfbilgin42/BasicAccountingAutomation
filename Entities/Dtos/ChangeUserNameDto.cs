using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ChangeUserNameDto : IDto
    {
        public string OldUserName { get; set; }
        public string NewUserName { get; set; }
        public string Password { get; set; }
    }
}
