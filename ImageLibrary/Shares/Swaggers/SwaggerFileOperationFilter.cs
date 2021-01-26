using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageLibrary.Shares.Swaggers
{
    public class SwaggerFileOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var a = operation.OperationId;
            if (operation.OperationId == "POST")
            {
                operation.Parameters.Clear();
                operation.Parameters.Add(new OpenApiParameter()
                {
                    Name = "UploadFile1",
                    Schema = new OpenApiSchema() { Type = "file" },
                    Required = true,
                    In = ParameterLocation.Header,
                    Description = "Upload File"
                });

            }
        }
    }
}
