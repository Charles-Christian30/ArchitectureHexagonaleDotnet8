using Domaine.Dto.PersonneDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.PersonneServiceFolder;

namespace le_site.mg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonneController : ControllerBase
    {
        private readonly IPersonneService _service;
        public PersonneController(IPersonneService service)
        {
            this._service = service;
        }

        [HttpPost]
        [Route("CreatePersonne")]
        public async Task<IActionResult> CreatePersonne(PersonneRequest personne)
        {
            IActionResult result = BadRequest();
            if(personne != null)
            {
                var item  = await this._service.CreatePersonne(personne);
                result = Ok(item);
            }
            return Ok(result);
        }
    }
}
