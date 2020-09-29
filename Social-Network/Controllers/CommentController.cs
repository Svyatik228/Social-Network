using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Dto;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Social_Network.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        public async Task<ActionResult> AddComment(CommentPostDto comment)
        {
            await _commentService.AddComment(comment);
            return Created("AddComment", comment);
        }

        [HttpGet("All Comments")]
        public ActionResult GetAllComments()
        {
            return Ok(_commentService.GetAll());
        }

        [HttpGet("id")]
        public IActionResult GetCommentById(string id)
        {
            return Ok(_commentService.GetById(id));
        }
    }
}
