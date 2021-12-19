using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sixteen_template_19._12._2021.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen_template_19._12._2021.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

      
    }
}
