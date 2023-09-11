using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using PolyCart.Common.Logging;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Configure App Configuration
builder.Configuration.AddJsonFile($"ocelot.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

// Add Ocelot and Cache Manager
builder.Services.AddOcelot().AddCacheManager(settings => settings.WithDictionaryHandle());

// Configure Logging
builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));
builder.Logging.AddConsole();
builder.Logging.AddDebug();

builder.Host.UseSerilog(SeriLogger.Configure);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseRouting();
await app.UseOcelot();

app.Run();
