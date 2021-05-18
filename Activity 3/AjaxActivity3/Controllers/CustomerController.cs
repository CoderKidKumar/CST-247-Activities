using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxActivity3.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxActivity3.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();

        public CustomerController()
        {
            customers.Add(new CustomerModel { ID = 0, Name = "Adam", Age = 50 });
            customers.Add(new CustomerModel { ID = 1, Name = "Leah", Age = 30 });
            customers.Add(new CustomerModel { ID = 2, Name = "Sarah", Age = 20 });
            customers.Add(new CustomerModel { ID = 3, Name = "Robert", Age = 46 });
            customers.Add(new CustomerModel { ID = 4, Name = "Maddie", Age = 16 });
            customers.Add(new CustomerModel { ID = 5, Name = "Nate", Age = 22 });
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult ShowCustomer(int ID)
        {
            CustomerModel c = customers.FirstOrDefault(x => x.ID == ID);
            return PartialView(c);
        }
    }
}
