using Microsoft.AspNetCore.Mvc;
using sixteen_template_19._12._2021.Data;
using sixteen_template_19._12._2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen_template_19._12._2021.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Member> members = _context.Members.ToList();
            return View(members);
        }
    }
}
