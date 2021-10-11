using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FerreteriaNetCore.DAO;
using FerreteriaNetCore.Models.DTOs.RequestsDTO;
using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.Controllers
{
    public class SignupController : Controller
    {
        private readonly ILogger<SignupController> _logger;

        public SignupController(ILogger<SignupController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(){
            return View("~/Views/Home/Signup.cshtml");
        }

        public IActionResult Signup(SignupDTO signupDTO)
        {
            using(DAOFactory daoFactory = new DAOFactory()){
                if(isValidUsername(daoFactory, signupDTO.Username) &&
                 !emailAlreadyUsed(daoFactory, signupDTO.Email) && 
                 passwordIsOk(signupDTO.Password, signupDTO.PasswordConfirmation)){
                    //crear usuario
                    //redirigir a signup comfirmed o ver como disparar una notificación de confirmación
                    return RedirectToAction("Index", "Home");
                }
                return RedirectToAction("Signup", "Signup");
            }
        }

        private bool usernameAlreadyExist(DAOFactory daoFactory, string username)
        {
            UserModel user = daoFactory.UserDAO.GetUserByName(username);

            return (user != null);
        }

        private bool isValidUsername(DAOFactory daoFactory, string username)
        {
            return (true && !usernameAlreadyExist(daoFactory, username)); //cambiar true por la validación de caracteres o remover este metodo
        }

        private bool emailAlreadyUsed(DAOFactory daoFactory, string email)
        {
            UserModel user = daoFactory.UserDAO.GetUserByEmail(email);

            return (user != null);
        }

        private bool passwordIsOk(string password, string passwordConfim)
        {
            return (password == passwordConfim);
        }

        private bool createUser(UserModel user)
        {
           return true;
        }
    }
}

