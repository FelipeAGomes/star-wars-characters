using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarWarsCharacters.Services;

namespace StarWarsCharacters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly ICharactersService _charactersService;

        public CharactersController(ICharactersService charactersService)
        {
            _charactersService = charactersService;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetCharacterNameAsync(string name)
        {
            try
            {
                var character = await _charactersService.GetCharactersByNameAsync(name);

                if (character == null || !character.Any())
                {
                    return NotFound($"Character with name {name} not found");
                }

                return Ok(character);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCharactersByPage([FromQuery] int page)
        {
            try
            {
                var characters = await _charactersService.GetCharactersByPageAsync(page);

                return Ok(characters);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
