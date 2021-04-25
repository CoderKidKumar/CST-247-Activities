using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LogMeIn(UserModel usermodel)
        {
            if(usermodel.Username == "NKumar1" && usermodel.Password == "12345")
            {
                return View("LoginSuccess", usermodel);
            }
            else
            {
                return View("LoginFail", usermodel);
            }
            
        }
    }
}
