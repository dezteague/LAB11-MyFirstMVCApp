using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int firstNumber, int secondNumber)
        {
            return RedirectToAction("Results", new { firstNumber, secondNumber });
        }

        [HttpGet]
        public IActionResult Results(int firstNumber, int secondNumber)
        {
            
            //do something with the number
            return View(TimePerson.GetPersons(firstNumber, secondNumber));
        }
        
    }
}
