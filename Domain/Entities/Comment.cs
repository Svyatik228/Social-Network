using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities
{
    [BsonCollection("comments")]
    public class Comment: Document
    {
        public string Text { get; set; }

        public string UserId { get; set; }

        public string OwnerId { get; set; }
    }
}
