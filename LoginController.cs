using Samplewebapi.Models;
using student.webapi.core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Samplewebapi.Controllers
{
    public class LoginController : ApiController
    {
        private ILoginRepository _loginRepository;
        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        [HttpGet]
        [Route("validateUser/{userName}/{password}")]
        public IHttpActionResult Login(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName)||string.IsNullOrEmpty(password))
            {
                return BadRequest();
            }
            var loginResponse = _loginRepository.ValidateUser(userName, password);
            return Ok(loginResponse);
        }
    }
}
