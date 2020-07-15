using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab21.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Registration registration)
        {
            // Save to a database??? 
            // Typically you would do something with this...
            // But for now we will just display the results

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(registration);
        }
    }
}
