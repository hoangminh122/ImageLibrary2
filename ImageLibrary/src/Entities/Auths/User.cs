﻿//using MongoDB.Bson;
//using MongoDB.Bson.Serialization.Attributes;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Threading.Tasks;

//namespace ImageLibrary.src.Entities.Auths
//{
//    public class User
//    {
//        [BsonId]
//        [BsonRepresentation(BsonType.ObjectId)]
//        public string InternalId { get; set; }

//        [BsonElement("code")]
//        public string Code { get; set; }

//        [BsonElement("name")]
//        public string Name { get; set; }

//        [BsonElement("date_updated")]
//        public DateTime DateUpdated { get; set; }

//        [BsonElement("date_created")]
//        public DateTime DateCreated { get; set; }

//        [BsonElement("avatar")]
//        public string Avatar { get; set; }

//        [BsonElement("email")]
//        public string Email { get; set; }

//        [BsonElement("date_of_birth")]
//        public string DateOfBirth { get; set; }

//        [BsonElement("phone")]
//        public string Phone {get;set;}

//        [BsonElement("address")]
//        public string Address { get; set; }

//        [BsonElement("password")]
//        public string Password { get; set; }

//        [BsonElement("is_actived")]
//        public bool IsActived { get; set; }

//        [BsonElement("roles")]
//        public Role[] ListRole { get; set; }








//    }
//}
