using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageLibrary.src.Entities
{
    public class RepositoryContext 
    {
        private readonly IMongoDatabase _database = null;
        public RepositoryContext(IOptions<Settings> settings)
        {
          //  var client = new MongoClient
        }
    }
}
