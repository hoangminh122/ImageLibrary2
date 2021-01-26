﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageLibrary.src.Entities
{
    public class UploadFile
    {
        public int Id { get; set; }
        public IFormFile files { get; set; }
        public string Name { get; set; }
    }
}
