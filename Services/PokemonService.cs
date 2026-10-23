using System.Net;
using System.Net.Http.Json;
using BlazorPokeApi.Models;

namespace BlazorPokeApi.Services;

public sealed class PokemonService(HttpClient http)
{
    public async Task<Pokemon?> BuscarAsync(string nome)
    {
        var termo = Uri.EscapeDataString(nome.Trim().ToLowerInvariant());
        using var resposta = await http.GetAsync($"pokemon/{termo}");
        if (resposta.StatusCode == HttpStatusCode.NotFound)
        {
            return null;
        }
        resposta.EnsureSuccessStatusCode();
        return await resposta.Content.ReadFromJsonAsync<Pokemon>();
    }
}
