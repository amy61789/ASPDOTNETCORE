using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class13Demo.Controllers
{
    public class ErrorController
    {
        [Route("Error")]
        public string Index()
        {
            return "Something went wrong";
        }
    }
}
