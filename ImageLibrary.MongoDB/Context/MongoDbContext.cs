using System;
using System.Collections.Generic;
using System.Text;
using ImageLibrary.MongoDB.Configuration.MongoDb;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ImageLibrary.MongoDB.Context
{
    public class MongoDbContext :IMongoDbContext
    {
        private readonly IMongoDatabase _database = null;

        public MongoDbContext(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if(client != null)
            {
                _database = client.GetDatabase(settings.Value.Database);
            }
        }
    }
}
