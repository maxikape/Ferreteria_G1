using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FerreteriaNetCore.DAO;
using FerreteriaNetCore.Models.DTOs.RequestsDTO;

namespace FerreteriaNetCore.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login(LoginDTO loginDTO)
        {
            IDAOFactory factory = IDAOFactory.Create();
            IUserDAO userDAO = factory.UserDAO;
            if (userDAO.FindUser(loginDTO.Username, loginDTO.Password) != null)
            {
                return RedirectToAction("Search", "Home");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
