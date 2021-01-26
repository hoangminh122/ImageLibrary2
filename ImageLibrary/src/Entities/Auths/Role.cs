using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageLibrary.src.Entities.Auths
{
    public class Role
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string InternalId { get; set; }

        [BsonElement("date_created")]
        public string DateCreated { get; set; }

        [BsonElement("date_updated")]
        public DateTime DateUpdated { get; set; }

        [BsonElement("role_name")]
        public string RoleName { get; set; }

        [BsonElement("role_code")]
        public string RoleCode { get; set; }

        [BsonElement("roleTypes")]
        public RoleType[] ListRoleType { get; set; }

    }
}
