using Activity2WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2WebApp.Controllers
{
    public class ButtonController : Controller
    {
        public IActionResult Index()
        {
            List<ButtonModel> buttons = new List<ButtonModel>();
            buttons.Add(new ButtonModel(true));
            buttons.Add(new ButtonModel(false));
            return View(buttons);
        }

    }
}
