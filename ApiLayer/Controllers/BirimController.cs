using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/birim")]
    [ApiController]
    public class BirimController : ControllerBase
    {
        private IBirimService birimService;

        public BirimController (IBirimService birimService)
        {
            this.birimService = birimService;   
        }
        [Authorize()]
        [Route(""),HttpGet]
        public IActionResult get()
        {
            return Ok(birimService.get());
        }
        [Authorize()]
        [Route("{id}"), HttpGet]
        public IActionResult getById(string id)
        {
            return Ok(birimService.getByid(id));
        }

        [Authorize()]
        [Route(""), HttpPost]
        public IActionResult add(Birim birim)
        {
            return Ok(birimService.insert(birim));
        }

        [Authorize()]
        [Route(""), HttpPut]
        public IActionResult update(Birim birim)
        {
            return Ok(birimService.update(birim));
        }

        [Authorize()]
        [Route("{id}"), HttpDelete]
        public IActionResult update(string id)
        {
            return Ok(birimService.delete(id));
        }






    }
}
