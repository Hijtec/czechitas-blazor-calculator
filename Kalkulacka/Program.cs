using Kalkulacka;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Přidání logování
builder.Logging.SetMinimumLevel(LogLevel.Debug);
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Zachytávání globálních chyb
AppDomain.CurrentDomain.UnhandledException += (sender, eventArgs) =>
{
    Console.Error.WriteLine($"Unhandled exception: {eventArgs.ExceptionObject}");
};

var host = builder.Build();
await host.RunAsync();
