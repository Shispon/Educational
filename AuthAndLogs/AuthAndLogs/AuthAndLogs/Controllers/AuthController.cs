using Microsoft.AspNetCore.Mvc;
using AuthAndLogs.Models;
using AuthAndLogs.Repositories;

namespace AuthAndLogs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {

        private readonly IAuthRepository _repository;
        public AuthController(IAuthRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("get")]
        public IActionResult GetUser()
        {
            var country = _repository.Select();
            return Ok(country);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(string login, string name, string mail, string password, string phone)
        {
            // Вызываем метод из репозитория
            var isSuccess = _repository.Insert(login, name, mail, password, phone);

            if (isSuccess)
            {
                // Пользователь успешно добавлен, возвращаем Ok
                return Ok("Пользователь успешно зарегистрирован");
            }
            else
            {
                // Логин уже существует, возвращаем BadRequest
                return BadRequest("Логин уже существует");
            }
        }

        [HttpPost]
        [Route("login")]

        public IActionResult Login(string login, string password)
        {
            var isAuthenticated = _repository.Login(login, password);
            if (isAuthenticated)
            {
                // Пользователь успешно аутентифицирован, возвращаем Ok
                Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:60763");
                return Ok("Аутентификация успешна");
            }
            else
            {
                // Неверный логин или пароль, возвращаем BadRequest
                Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:60763");  
                return BadRequest("Неверный логин или пароль");
            }
        }
    }
}
