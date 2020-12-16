using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Application.Services.Interfaces
{
    interface IJwtService
    {
        string GenerateJWTTokenAsync(User userDTO);
    }
}
