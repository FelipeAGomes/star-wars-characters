using Newtonsoft.Json;
using StarWarsCharacters.Models;

namespace StarWarsCharacters.Services
{
    public class CharactersService : ICharactersService
    {
        private readonly IApiFetchService _apiFetchService;

        public CharactersService(IApiFetchService apiFetchService)
        {
            _apiFetchService = apiFetchService;
        }

        public async Task<List<CharactersModel>> GetCharactersByNameAsync(string name)
        {
            try
            {
                var charactersJson = await _apiFetchService.GetCharactersJsonAsync(name);
                var apiResponse = JsonConvert.DeserializeObject<CharactersApiResponse>(charactersJson);
                var characters = apiResponse.Results.ToList();

                if (characters.Count == 0)
                {
                    throw new Exception();
                }

                return characters;
            }
            catch (HttpRequestException ex)
            {
                throw new ApplicationException($"Error making HTTP request: {ex.Message}", ex);
            }
            catch (JsonException ex)
            {
                throw new ApplicationException($"Error deserializing JSON: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"No characters found with the name '{name}'.", ex);
            }
        }

        public async Task<List<CharactersModel>> GetCharactersByPageAsync(int page)
        {
            try
            {
                var charactersJson = await _apiFetchService.GetCharactersByPageAsync(page);

                var apiResponse = JsonConvert.DeserializeObject<CharactersApiResponse>(charactersJson);
                var characters = apiResponse.Results;

                return characters;
            }
            catch (HttpRequestException ex)
            {
                throw new ApplicationException($"Error making HTTP request: {ex.Message}", ex);
            }
            catch (JsonException ex)
            {
                throw new ApplicationException($"Error deserializing JSON: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Unexpected error retrieving characters for page {page}: {ex.Message}", ex);
            }
        }
    }
}
