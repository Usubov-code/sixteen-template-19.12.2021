﻿using Microsoft.AspNetCore.Mvc;
using sixteen_template_19._12._2021.Data;
using sixteen_template_19._12._2021.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen_template_19._12._2021.Controllers
{
    public class ProductController : Controller
    {

        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          

            return View();
        }
    }
}
