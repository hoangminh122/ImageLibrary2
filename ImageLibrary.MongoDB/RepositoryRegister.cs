using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using ImageLibrary.MongoDB.Configuration.MongoDb;
using ImageLibrary.MongoDB.Context;
using ImageLibrary.MongoDB.Repository;

namespace ImageLibrary.MongoDB
{
    public static class RepositoryRegister
    {
        public static void AddMongoDbRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoDbSettings>( options =>
            {
                options.ConnectionString
                 = configuration["MongoSettings:ConnectionString"];
                options.Database
                 = configuration["MongoSettings:Database"];
            });

            services.AddSingleton(typeof(IMongoRepository<,>), typeof(MongoRepository<,>));

        }

        public static void AddMongoDbRepository(this IServiceCollection services, string connectionString,string database)
        {
            services.Configure<MongoDbSettings>(options =>
            {
                options.ConnectionString = connectionString;
                options.Database = database;
            });

            services.AddSingleton(typeof(IMongoRepository<,>),typeof(MongoRepository<,>));
        }
    }
}
