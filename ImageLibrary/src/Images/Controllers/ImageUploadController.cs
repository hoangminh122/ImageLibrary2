using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using ImageLibrary.src.Entities;
using System.IO;

namespace ImageLibrary.src.Images.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class ImageUploadController:ControllerBase
    {
        public static IWebHostEnvironment _enviroment;
        public ImageUploadController(IWebHostEnvironment enviroment)
        {
            _enviroment = enviroment;
        }


        [HttpPost]
        [Route("upload")]
        public async Task<string> PostFile([FromForm] UploadFile objFile)
        {
            if(objFile.files.Length > 0 )
            {
                if(!Directory.Exists(_enviroment.ContentRootPath + "\\Uploads\\"))
                {
                    Directory.CreateDirectory(_enviroment.ContentRootPath+"\\Uploads\\");
                }
                using (FileStream fileStream = System.IO.File.Create(_enviroment.ContentRootPath + "\\Uploads\\"+objFile.files.FileName))
                {
                    await objFile.files.CopyToAsync(fileStream);
                    await  fileStream.FlushAsync();
                    return objFile.files.FileName;
                }
            }
            else
            {
                return "Failed";
            }

        }



    }
}
