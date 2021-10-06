using FerreteriaNetCore.Models;
using FerreteriaNetCore.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace FerreteriaNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult PasswordRecovery()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View("~/Views/Home/ProductSearch.cshtml");
        }

        public IActionResult ProductEdit()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
