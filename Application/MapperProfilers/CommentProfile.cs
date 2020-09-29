using System;
using System.Collections.Generic;
using System.Text;
using Application.Dto;
using AutoMapper;
using Domain.Entities;

namespace Application.MapperProfilers
{
    public class CommentProfile: Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentGetDto>().ReverseMap();
            CreateMap<CommentPostDto, Comment>().ReverseMap();
        }
    }
}
