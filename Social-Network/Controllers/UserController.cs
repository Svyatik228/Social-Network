using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Social_Network.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMongoRepository<User> _usersRepository;

        public UserController(IMongoRepository<User> usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpPost("registerPerson")]
        public async Task AddUser(User user)
        {
            await _usersRepository.InsertOneAsync(user);
        }

    }
}
