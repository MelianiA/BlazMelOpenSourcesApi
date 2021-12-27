using BlazMelOpenSourcesApi;
using BlazMelOpenSourcesApi.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddCors(options =>
{
    options.AddPolicy("local",
                     builder =>
                         builder.WithOrigins("http://api.deezer.com")
                                .AllowAnyMethod()
                                .AllowAnyHeader());
});


builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient {
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IChatService, ChatService>();

await builder.Build().RunAsync();
