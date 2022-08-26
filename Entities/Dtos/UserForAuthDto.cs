using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class UserForAuthDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
