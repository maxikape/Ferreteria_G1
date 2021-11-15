using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FerreteriaNetCore.DAO;
using FerreteriaNetCore.Models.DTOs.RequestsDTO;
using FerreteriaNetCore.Models.Entities;
using FerreteriaNetCore.Models.DTOs.ResponseDTO;
using Microsoft.AspNetCore.Http;

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
            UserResponse userResponse = HttpContext.Session.Get<UserResponse>("UsuarioLogueado");
            if (userResponse != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else{
                return View("~/Views/User/Signup.cshtml");
            }
        }

        public IActionResult Signup(SignupDTO signupDTO)
        {
            using(DAOFactory daoFactory = new DAOFactory()){
                if(isValidUsername(daoFactory, signupDTO.Username) &&
                 !emailAlreadyUsed(daoFactory, signupDTO.Email) && 
                 passwordIsOk(signupDTO.Password, signupDTO.PasswordConfirmation)){
                    UserModel newUser = new UserModel();
                    newUser.Id = 0;
                    newUser.Username = signupDTO.Username;
                    newUser.Password = signupDTO.Password;
                    newUser.Email = signupDTO.Email;
                    newUser.Birthdate = signupDTO.Bithdate;
                    
                    //TODO crear usuario
                    daoFactory.BeginTrans();
                    daoFactory.UserDAO.SaveUser(newUser);
                    daoFactory.Commit();

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

