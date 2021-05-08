using Activity2WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2WebApp.Controllers
{
    public class test : Controller
    {
        public IActionResult Index()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel { Name = "Brian Smith", EmailAddress = "BrianNotBrain@teleworm.us", PhoneNumber = "720-228-6165" });
            users.Add(new UserModel { Name = "James King", EmailAddress = "JamesKing@booyah.com", PhoneNumber = "304-546-9303" });
            users.Add(new UserModel { Name = "Tom Molland", EmailAddress = "MollandTom2@deking.com", PhoneNumber = "400-354-1234" });
            users.Add(new UserModel { Name = "Jaiden Foster", EmailAddress = "Jaiden@animators.net", PhoneNumber = "764-029-5516" });
            users.Add(new UserModel { Name = "Maria Kosta", EmailAddress = "Maria@dayrep.com", PhoneNumber = "855-102-7767" });
   
            return View(users);
        }
    }
}
