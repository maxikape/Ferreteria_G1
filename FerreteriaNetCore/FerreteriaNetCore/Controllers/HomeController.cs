using FerreteriaNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using FerreteriaNetCore.Models.DTOs.ResponseDTO;
using Microsoft.AspNetCore.Http;

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

        public IActionResult Search()
        {
            UserResponse userResponse = HttpContext.Session.Get<UserResponse>("UsuarioLogueado");
            if (userResponse != null)
            {
                return View("~/Views/Home/ProductSearch.cshtml");
            }
            else{
                return RedirectToAction("Index", "Home");
            }
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
