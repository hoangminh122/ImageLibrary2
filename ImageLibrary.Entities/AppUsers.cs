using ImageLibrary.MongoDB.ApplicationBase.Entity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageLibrary.Entities
{
    public class AppUsers : IEntity<ObjectId>
    {
        public string FirstName { get; set; }
     

        public ObjectId Id { get; set; }
    }
}
