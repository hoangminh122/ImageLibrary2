using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ImageLibrary.Entities.Models.Auths
{
    public class RoleType
    {

        [BsonElement("code")]
        public string Code { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("date_created")]
        public string DateCreated { get; set; }

        [BsonElement("date_updated")]
        public DateTime DateUpdated { get; set; }

    }
}
