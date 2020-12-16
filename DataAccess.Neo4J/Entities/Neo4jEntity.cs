using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace DataAccess.Neo4J
{
    public class Neo4jEntity : IEntity
    {
        protected Neo4jEntity()
        {
            LastUpdated = DateTime.UtcNow;
        }

        [JsonIgnore]
        [XmlIgnore]
        public string Label { get; protected set; }

        [JsonIgnore]
        [XmlIgnore]
        public DateTimeOffset LastUpdated { get; set; }
    }
}
