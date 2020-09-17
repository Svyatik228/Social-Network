using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities
{
    [BsonCollection("users")]
    public class User: Document
    {

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
