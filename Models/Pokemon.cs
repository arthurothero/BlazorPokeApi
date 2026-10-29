using System.Text.Json.Serialization;

namespace BlazorPokeApi.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public string? name { get; set; }

        // A API devolve a altura em decímetros e o peso em hectogramas.
        public int height { get; set; }
        public int weight { get; set; }

        public Sprites? sprites { get; set; }
    }

    public class Sprites
    {
        public OtherSprites? other { get; set; }
    }

    public class OtherSprites
    {
        [JsonPropertyName("official-artwork")]
        public OfficialArtwork? officialArtwork { get; set; }
    }

    public class OfficialArtwork
    {
        public string? front_default { get; set; }
    }
}
