using _13768.Application.Dtos;
using _13768.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WAD.CW._13768.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        
        public ContactController(
            IContactService service)
        {
            _contactService = service;
            
        }

        /// <summary>
        /// Get the contact by the unique identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetContactById")]
        public IActionResult Get([FromRoute]int id)
        {
            var details = _contactService.GetContact(id);
            if (details == null)
            {
                return Ok(details);
            }

            return NotFound();
        }

        /// <summary>
        /// Retrieve the list of contacts from the database.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _contactService.GetAllAsync();
            return Ok(result);
        }

        [HttpPost("Create")]
        public IActionResult Post([FromForm]ContactDto dto)
        {
            _contactService.CreateContact(dto);
            return Created("Post", dto);
        }


    }
}
