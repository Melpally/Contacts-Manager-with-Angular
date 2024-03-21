using _13768.Application.Dtos;
using _13768.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WAD.CW._13768.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _service;
        public CompanyController(ICompanyService companyService)
        {
            _service = companyService;
        }

        /// <summary>
        /// Gets the company by the unique identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetCompanyById/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var details = _service.GetCompany(id);
            if (details != null)
            {
                return Ok(details);
            }

            return NotFound();
        }

        /// <summary>
        /// Retrieve the list of companies from the database.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpPost("Create")]
        public IActionResult Post([FromForm] CompanyDto dto)
        {
            _service.CreateCompany(dto);
            return Created("Post", dto);
        }

        [HttpPost("Update/{id}")]
        public IActionResult Update([FromForm] CompanyDto dto, [FromRoute] int id)
        {
            _service.UpdateCompany(id, dto);
            return Ok(dto);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _service.DeleteCompany(id);
            return Ok("Deleted");
        }
    }
}
