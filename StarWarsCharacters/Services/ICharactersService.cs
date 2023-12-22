using System;
using System.Threading.Tasks;
using StarWarsCharacters.Models;

namespace StarWarsCharacters.Services
{
	public interface ICharactersService
	{
        public Task<List<CharactersModel>> GetCharactersByNameAsync(string name);
        public Task<List<CharactersModel>> GetCharactersByPageAsync(int page);

    }
}

