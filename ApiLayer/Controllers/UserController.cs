using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [Authorize()]
        [Route(""),HttpGet]
        public IActionResult get()
        {
            return Ok(userService.get());
        }
        [Authorize()]
        [Route("{id}"), HttpDelete]
        public IActionResult delete(string id)
        {
            return Ok(userService.delete(id));
        }
    }
}
