using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StarWarsCharacters.Services
{
	public class ApiFetchService : IApiFetchService
	{
        private readonly IHttpClientFactory _clientFactory;
        private readonly IConfiguration _configuration;

        public ApiFetchService(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
        }

        public async Task<string> GetCharactersJsonAsync(string name)
        {
            var apiUrl = $"{_configuration["StarWarsApiUrl"]}/?search={name}";
            var client = _clientFactory.CreateClient();

            var response = await client.GetStringAsync(apiUrl);

            return response;
        }

        public async Task<string> GetCharactersByPageAsync(int page)
        {
            var apiUrl = $"{_configuration["StarWarsApiUrl"]}/?page={page}";
            var client = _clientFactory.CreateClient();
            var response = await client.GetStringAsync(apiUrl);

            return response;
        }
    }
}

