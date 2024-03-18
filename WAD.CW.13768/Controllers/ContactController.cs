using _13768.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WAD.CW._13768.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;
        private readonly IContactService _contactService;
        
        public ContactController(
            ILogger<ContactController> logger,
            IContactService service)
        {
            _contactService = service;
            _logger = logger;
        }

        [HttpGet(Name = "GetContactById")]
        public IActionResult Get([FromRoute]int id)
        {
            return Ok(_contactService.GetContact(id));
        }
    }
}
