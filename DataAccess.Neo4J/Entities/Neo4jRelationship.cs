using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataAccess.Neo4J
{
    public class Neo4jRelationship
    {
        [JsonIgnore]
        public string Name { get; set; }
    }
}
