using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Coba2.Models;

namespace Coba2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Person> _person = new List<Person>()
            {
                new Person {Name = "Raka Gilang Prakarsa", Country = "Indonesia" }
            };
            return View();

        }
    }

}