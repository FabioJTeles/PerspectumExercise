using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerspectumExercise.Models
{
    public class FileModel
    {
        public IFormFile Upload{ get; set; }
    }
}