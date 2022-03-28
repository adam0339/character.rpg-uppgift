using Adam.albadre.omnisharp.Models;

namespace Adam.albadre.omnisharp.Services.CharacterServices
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacter();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
         
    }
}