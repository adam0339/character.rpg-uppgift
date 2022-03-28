using Adam.albadre.omnisharp.Models;

namespace Adam.albadre.omnisharp.Services.CharacterServices
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> character = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "sami"}

        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var ServiceResponse = new ServiceResponse<List<Character>>();
            character.Add(newCharacter);
            ServiceResponse.Data = character;
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacter()
        {
            var ServiceResponse = new ServiceResponse<List<Character>>();
            ServiceResponse.Data = character;
            return ServiceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var ServiceResponse = new ServiceResponse<Character>();
            ServiceResponse.Data = character.FirstOrDefault(c => c.Id == id);
            return ServiceResponse;
        }
    }
}