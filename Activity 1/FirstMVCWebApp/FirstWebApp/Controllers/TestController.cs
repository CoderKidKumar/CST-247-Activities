using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Test/Play
        public string Play()
        {
            // Return a string as a View
            return @"<b>Hello World as a string from Play</b>";
        }

        //GET: /Test/TestView
        public IActionResult TestView()
        {
            //Return "TestView.cshtml"
            return View();
        }
    }
}
