using System;
using Newtonsoft.Json;

namespace StarWarsCharacters.Models
{
	public class CharactersApiResponse
	{
        [JsonProperty("results")]
        public List<CharactersModel> Results { get; set; }
    }
}

