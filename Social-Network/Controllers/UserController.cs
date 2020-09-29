using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Dto;
using Application.Services.Implementation;
using Application.Services.Interfaces;
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
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("registerPerson")]
        public async Task<ActionResult> AddUser(UserDto user)
        {
            await _userService.AddUser(user);
            return Created("AddUser", user);
        }

        [HttpGet("registerPersons")]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpGet("id")]
        public IActionResult GetUserById(string id)
        {
            return Ok(_userService.GetById(id));
        }

        [HttpDelete]
        public IActionResult DeleteUserById(string id)
        {
            return Ok(_userService.RemoveUser(id));
        }

    }
}
