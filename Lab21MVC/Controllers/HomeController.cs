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



        public IActionResult NewUser(NewUser user)
        {
            if (ModelState.IsValid)
            {
                ViewBag.User = user;
                return View();
            }
            else
            {
                return View();
            }
        }

        

        }
    }
