using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;
using Application.Services.Interfaces;
using AutoMapper;
using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Application.Services.Implementation
{
    public class UserService: IUserService
    {
        private readonly IMongoRepository<User> _userRepository;
        private IMapper _mapper;
        public UserService(IMongoRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task AddUser(UserDto userDto)
        {
            await _userRepository.InsertOneAsync(_mapper.Map<UserDto, User>(userDto));
        }

        public List<UserDto> GetAllUsers()
        {
            var users= _mapper.Map<List<User>, List<UserDto>> ( _userRepository.FilterBy(_ => true).ToList());
            return users;
        }

        public IEnumerable<UserDto> GetById(string userId)
        {
            var user = _mapper.Map<IEnumerable<User>, IEnumerable<UserDto>>(_userRepository.FilterBy(m => m.UserId == userId));
            return user;
        }

        public async Task RemoveUser(string userId)
        {
            await _userRepository.DeleteOneAsync(m => m.UserId == userId);
        }

        public Task UpdateUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}
