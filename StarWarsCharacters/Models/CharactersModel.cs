using System;
using Newtonsoft.Json;

namespace StarWarsCharacters.Models
{
	public class CharactersModel
	{
        public string Name { get; set; }

        public string Height { get; set; }

        public string Hair_Color { get; set; }

        public string Skin_Color { get; set; }

        public string Eye_Color { get; set; }

        public string Birth_Year { get; set; }

        public string Gender { get; set; }

        public string Url { get; set; }

        public string Photo { get{

                var items = Url.Split('/', StringSplitOptions.RemoveEmptyEntries);

                return $"https://starwars-visualguide.com/assets/img/characters/{items[4]}.jpg";
            } }

    }
}