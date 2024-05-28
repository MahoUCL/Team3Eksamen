using Blazored.LocalStorage;
using HundeRally.Wasm;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http.Headers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



// Intended dependency injection for the token that holds the users login data. Provides a new instance of the dependency in every HTTP request

//builder.Services.AddTransient(sp => new HttpClient
//{
//    BaseAddress = new Uri("https://localhost:7010/api/"),
//    DefaultRequestHeaders = { Authorization = new AuthenticationHeaderValue("Bearer", token) }
//});

// Intended dependency injection for the token that holds the users login data locally
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
