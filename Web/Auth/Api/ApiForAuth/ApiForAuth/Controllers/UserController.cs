using ApiForAuth.Repository;
using ApiForAuth.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiForAuth.Models;


namespace ApiForAuth.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("insertUser")]
        public ActionResult<UserResponse> InsertUser(UserModel user)
        {
            var response = _repository.InsertUser(user);
            return Ok(response);
        }

        [HttpPost]
        [Route("login")]
        public ActionResult<UserResponse> LoginUser([FromBody] UserAuth user)
        {
            var response = _repository.AuthenticateUser(user);
            return Ok(response);
        }
    }


}


