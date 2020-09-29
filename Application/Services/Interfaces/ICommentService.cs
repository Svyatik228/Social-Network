using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Services.Interfaces
{
    public interface ICommentService
    {
        /// <summary>
        /// Retrieve comment by ID
        /// </summary>
        /// <param name="id">Comment's ID</param>
        /// <returns>returns book root comment DTO</returns>
        IEnumerable<CommentGetDto> GetById(string id);


        /// <summary>
        /// Retrieve all comments
        /// </summary>
        /// <returns>returns enumerable of comment DTOs</returns>
        List<CommentGetDto> GetAll();


        /// <summary>
        /// Create new comment and add it into Database
        /// </summary>
        /// <param name="insertDto">Commnet DTO instance</param>
        /// <returns>Number of inserted commnets</returns>
        Task AddComment(CommentPostDto insertDto);
    }
}
