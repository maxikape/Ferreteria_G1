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

            HttpContext.Session.Clear();

            return View();
        }


        public IActionResult PasswordRecovery()
        {
            UserResponse userResponse = HttpContext.Session.Get<UserResponse>("UsuarioLogueado");
            if (userResponse != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else{
                return View("~/Views/User/PasswordRecovery.cshtml");
            }
        }

        public IActionResult Search()
        {
            UserResponse userResponse = HttpContext.Session.Get<UserResponse>("UsuarioLogueado");
            if (userResponse != null)
            {
                return View("~/Views/Product/ProductSearch.cshtml");
            }
            else{
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult ProductEdit()
        {
            UserResponse userResponse = HttpContext.Session.Get<UserResponse>("UsuarioLogueado");
            if (userResponse != null)
            {
                return View("~/Views/Product/ProductEdit.cshtml");
            }
            else{
                return RedirectToAction("Index", "Home");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
