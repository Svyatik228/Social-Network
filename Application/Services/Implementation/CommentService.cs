using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;
using Application.Services.Interfaces;
using AspNetCore.Identity.MongoDbCore.Infrastructure;
using AutoMapper;
using Domain;
using Domain.Entities;

namespace Application.Services.Implementation
{
    public class CommentService: ICommentService
    {
        private readonly IMongoRepository<Comment> _commentRepository;
        private readonly IMapper _mapper;
        public CommentService(IMongoRepository<Comment> commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public async Task AddComment(CommentPostDto insertDto)
        {
            await _commentRepository.InsertOneAsync(_mapper.Map<CommentPostDto, Comment>(insertDto));
        }

        public List<CommentGetDto> GetAll()
        {
            return _mapper.Map<List<Comment>, List<CommentGetDto>> (_commentRepository.FilterBy(_ => true).ToList());
        }

        public  IEnumerable<CommentGetDto> GetById(string id)
        {
            return _mapper.Map<IEnumerable<Comment>, IEnumerable<CommentGetDto>>(_commentRepository.FilterBy(m => m.UserId == id));
        }
    }
}
