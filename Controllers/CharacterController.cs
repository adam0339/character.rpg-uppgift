using Microsoft.AspNetCore.Mvc;

using Adam.albadre.omnisharp.Models;
using Adam.albadre.omnisharp.Services.CharacterServices;

namespace Adam.albadre.omnisharp.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _CharacterService;

        public CharacterController(ICharacterService CharacterService)
        {
            _CharacterService = CharacterService;

        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()

        {
            return Ok(await _CharacterService.GetAllCharacter());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id)
        {
            return Ok(await _CharacterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
        {
            return Ok(await _CharacterService.AddCharacter(newCharacter));

        }
    }
}