using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService authService;
        public AuthController (IAuthService authService)
        {
            this.authService = authService;
        }
        [Route("register"),HttpPost]
        public IActionResult register(LoginDTO login)
        {
            return Ok(authService.Register(login));
        }
        [Route("login"), HttpPost]
        public IActionResult login(LoginDTO login)
        {
            return Ok(authService.Login(login));
        }


    }
}
