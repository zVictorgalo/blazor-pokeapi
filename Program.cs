using BlazorPokeApi;
using BlazorPokeApi.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(_ => new HttpClient
{
    BaseAddress = new Uri("https://pokeapi.co/api/v2/"),
    Timeout = TimeSpan.FromSeconds(20)
});
builder.Services.AddScoped<PokemonService>();
await builder.Build().RunAsync();
