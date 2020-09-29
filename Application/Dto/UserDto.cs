using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace Application.Dto
{
    public class UserDto
    {
        public string UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
