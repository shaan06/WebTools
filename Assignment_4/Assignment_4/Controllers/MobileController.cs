using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment4.Controllers
{
    public class MobileController : Controller
    {
        public IActionResult Index()
        {
            MobileDetailsManager md = new MobileDetailsManager();
            var mobile  = md.GetAll;
            return View(mobile);
         
        }
    }
}