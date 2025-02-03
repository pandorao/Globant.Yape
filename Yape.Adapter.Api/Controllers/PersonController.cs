using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Yape.Entities;
using Yape.Entities.Base;
using Yape.Ports.Input;
using Yape.Services;

namespace Yape.Adapter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ServiceResult<Person>))]
        public async Task<ActionResult> Get()
        {
            return Ok(await _personService.GetAllAsync());
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ServiceResult<Person>))]
        public async Task<ActionResult> Post(Person model)
        {
            return Ok(await _personService.AddAsync(model));
        }
    }
}
