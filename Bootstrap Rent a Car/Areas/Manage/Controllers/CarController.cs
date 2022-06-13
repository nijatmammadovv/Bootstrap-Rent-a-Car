using Bootstrap_Rent_a_Car.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap_Rent_a_Car.Areas.Manage.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(Car)
        {
            return View();
        }
    }
}
