using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ImageLibrary.Entities.Models.Auths
{
    public class Role
    {

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
