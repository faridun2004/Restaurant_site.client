using BankManagementSystem.Client.Sevices;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Restaurant_site.client;
using Restaurant_site.client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var serverURL = new Uri("http://localhost:5055");
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5055") });

builder.Services.AddHttpClient("ServerAPI", client => client.BaseAddress = serverURL);
builder.Services.AddScoped<IHttpAPIProvider, HttpAPIProvider>();
builder.Services.AddScoped<ITokenProvider, TokenProvider>();
builder.Services.AddBlazoredLocalStorageAsSingleton();

await builder.Build().RunAsync();
