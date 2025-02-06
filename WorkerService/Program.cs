using Domain.Models;
using ExternalResources.Services;
using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WorkerService.Services;

// appsettings.json
var fileBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false);
IConfiguration config = fileBuilder.Build();
var httpSettings = config.GetSection("HttpSettings").Get<HttpSettings>() ?? new();

// Services
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHangfire(c => c.UseMemoryStorage());
builder.Services.AddScoped<IHttpService, HttpService>();
builder.Services.AddScoped<IWorkerService, WorkerService.Services.WorkerService>();

// Host
using IHost host = builder.Build();
using IServiceScope serviceScope = host.Services.CreateScope();
IServiceProvider provider = serviceScope.ServiceProvider;
var workerService = provider.GetRequiredService<IWorkerService>();

// Hangfire
GlobalConfiguration.Configuration.UseMemoryStorage();
using (var server = new BackgroundJobServer())
{
    Console.WriteLine("Hangfire Server started. Press any key to exit...");
    workerService.UpsertAnimeList(httpSettings.BaseUrl, CancellationToken.None);
    Console.ReadKey();
}

