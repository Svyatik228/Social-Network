using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;
using Application.Services.Interfaces;
using AutoMapper;
using DataAccess.Neo4J.Entities;
using DataAccess.Neo4J.Neo4jRepository;
using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Application.Services.Implementation
{
    public class UserService: IUserService
    {
        private readonly IMongoRepository<User> _userRepository;
        private Neo4jRepository<Neo4JUser> _neo4JRepository;
        private IMapper _mapper;
        public UserService(IMongoRepository<User> userRepository, IMapper mapper, Neo4jRepository<Neo4JUser> neo4JRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _neo4JRepository = neo4JRepository;
        }

        public async Task AddUser(UserDto userDto)
        {
            await _userRepository.InsertOneAsync(_mapper.Map<UserDto, User>(userDto));
            await _neo4JRepository.Add(new Neo4JUser());

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
