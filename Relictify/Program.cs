using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Relictify;
using Relictify.Backend.API;
using Relictify.Backend.WebStorage;
using Relictify.Startup;
using Relictify.StateManagement;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IStateService, StateService>();
builder.Services.AddScoped<IWebStorage, WebStorage>();
builder.Services.AddScoped<IRelicStore, RelicStore>();
builder.Services.AddScoped<IEntryStore, EntryStore>();
builder.Services.AddScoped<IStartupService, StartupService>();

await builder.Build().RunAsync();