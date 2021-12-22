
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sixteen_template_19._12._2021.Data;
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
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        

        public IActionResult Index()
        {
            return View();
        }

      
    }
}
