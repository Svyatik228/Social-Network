using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;
using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IUserService
    {
       List<UserDto> GetAllUsers();

        /// <summary>
        /// Get user by Id
        /// </summary>
        /// <param name="predicate">Predicate</param>
        /// <returns></returns>
        /// 
        IEnumerable<UserDto> GetById(string userId);

        Task UpdateUser(UserDto userDto);

        Task RemoveUser(string userId);

        Task AddUser(UserDto userRegisterDto);
    }
}
