using _13768.Application.Dtos;
using _13768.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WAD.CW._13768.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _service;
        public TeamController(ITeamService teamService)
        {
            _service = teamService; 
        }

        /// <summary>
        /// Get the team by the unique identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetTeamById/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var details = _service.Get(id);
            if (details != null)
            {
                return Ok(details);
            }

            return NotFound();
        }

        /// <summary>
        /// Retrieve the list of teams from the database.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpPost("Create")]
        public IActionResult Post([FromForm] TeamDto dto)
        {
            _service.Create(dto);
            return Created("Post", dto);
        }

        [HttpPost("Update/{id}")]
        public IActionResult Update([FromForm] TeamDto dto, [FromRoute] int id)
        {
            _service.Update(id, dto);
            return Ok();
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _service.Delete(id);
            return Ok();
        }

    }
}
