using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab21MVC.Models;


namespace Lab21MVC.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            //    ViewBag.CurrentUser = new NewUser() { UserName = "i  am user" };
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewUser(NewUser user)
        {
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                ViewBag.Error = "You Done Messed Up!";
                return RedirectToAction("Index");
            }
        }
    }
}
