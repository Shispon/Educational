using AuthAndLogs.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AuthAndLogs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogsController : Controller
    {
        private readonly ILogsRepository _repository;
        public LogsController(ILogsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("get")]
        public IActionResult GetUser()
        {
            var country = _repository.Select();
            Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:60763");
            return Ok(country);
        }

        [HttpPost]
        [Route("insert")]
        public IActionResult LogInsert(string message, string ip, string route)
        {
            var country = _repository.Insert(message, ip, route);
            Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:60763");
            return Ok("log отпрвлен");
        }
    }
}
