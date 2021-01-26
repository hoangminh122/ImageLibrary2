using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using ImageLibrary.MongoDB.Configuration.MongoDb;
using ImageLibrary.MongoDB.Context;

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

            services.AddSingleton<IMongoDbContext,MongoDbContext>();

        }
    }
}
