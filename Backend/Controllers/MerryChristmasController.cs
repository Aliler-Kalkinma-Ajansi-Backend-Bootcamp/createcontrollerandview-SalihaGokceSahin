﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public class MerryChristmasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
