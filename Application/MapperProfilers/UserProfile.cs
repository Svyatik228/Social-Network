using System;
using System.Collections.Generic;
using System.Text;
using Application.Dto;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapper
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
