using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorPokeApi;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient apontando para a PokeAPI (HTTPS e CORS liberado).
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://pokeapi.co/")
});

await builder.Build().RunAsync();
