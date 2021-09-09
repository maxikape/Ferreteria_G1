using FerreteriaNetCore.Models;
using FerreteriaNetCore.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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

        public IActionResult Privacy()
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

        public IActionResult Login(String userName, String password)
        {
            IDAOFactory factory = IDAOFactory.Create();
            IUserDAO userDAO = factory.UserDAO;
            if (userDAO.FindUser(userName, password) != null)
            {
                return RedirectToAction("Search", "Home");
            }

            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
