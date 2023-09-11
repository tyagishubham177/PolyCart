using PolyCart.Common.Logging;
using PolyCart.Discount.Grpc.Extensions;
using PolyCart.Discount.Grpc.Mapper;
using PolyCart.Discount.Grpc.Repositories;
using PolyCart.Discount.Grpc.Services;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
builder.Services.AddScoped<IDiscountRepository, DiscountRepository>();

builder.Services.AddAutoMapper(typeof(DiscountProfile).Assembly);

// Add services to the container.
builder.Services.AddGrpc();

builder.Host.UseSerilog(SeriLogger.Configure);

var app = builder.Build();

app.Services.CreateScope().ServiceProvider.GetRequiredService<IHost>().MigrateDatabase<Program>();

// Configure the HTTP request pipeline.
//app.MapGrpcService<GreeterService>();
app.MapGrpcService<DiscountService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
