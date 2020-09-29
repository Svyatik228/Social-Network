using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace Application.Dto
{
    public class CommentGetDto
    {
        public ObjectId Id { get; set; }

        public string Text { get; set; }

        public string UserId { get; set; }

        public string OwnerId { get; set; }
    }
}
