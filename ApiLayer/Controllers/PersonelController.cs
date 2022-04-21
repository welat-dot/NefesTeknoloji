using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/personel")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        private IPersonelService personelService;

        public PersonelController(IPersonelService personelService)
        {
            this.personelService = personelService;
        }

        [Authorize()]
        [Route(""), HttpGet]
        public IActionResult get()
        {
            return Ok(personelService.get());
        }

        //[Authorize()]
        //[Route("getjoin"), HttpGet]
        //public IActionResult getAllJoin()
        //{
        //    return Ok(personelService.GetAllJoin());
        //}

        [Authorize()]
        [Route("{id}"), HttpGet]
        public IActionResult getById(string id)
        {
            return Ok(personelService.getByid(id));
        }
        [Authorize()]
        [Route(""), HttpPost]
        public IActionResult add(Personel personel)
        {
            return Ok(personelService.insert(personel));
        }
        [Authorize()]
        [Route(""), HttpPut]
        public IActionResult update(Personel personel)
        {
            return Ok(personelService.update(personel));
        }
        [Authorize()]
        [Route("{id}"), HttpDelete]
        public IActionResult delete(string id)
        {
            return Ok(personelService.delete(id));
        }




    }
}
