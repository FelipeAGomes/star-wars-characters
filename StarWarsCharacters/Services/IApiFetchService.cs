using System;
namespace StarWarsCharacters.Services
{
	public interface IApiFetchService
	{
        Task<string> GetCharactersByPageAsync(int page);
        Task<string> GetCharactersJsonAsync(string name);
    }
}

