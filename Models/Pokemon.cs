using System.Text.Json.Serialization;

namespace BlazorPokeApi.Models;

public sealed class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Height { get; set; }
    public int Weight { get; set; }
    public PokemonSprites? Sprites { get; set; }
    public decimal AlturaMetros => Height / 10m;
    public decimal PesoQuilos => Weight / 10m;
    public string? Imagem => Sprites?.Other?.OfficialArtwork?.FrontDefault;
}

public sealed class PokemonSprites
{
    public OtherSprites? Other { get; set; }
}

public sealed class OtherSprites
{
    [JsonPropertyName("official-artwork")]
    public Artwork? OfficialArtwork { get; set; }
}

public sealed class Artwork
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}
