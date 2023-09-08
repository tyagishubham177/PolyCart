using PolyCart.Web.Data;
using PolyCart.Web.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Read configuration
var configuration = builder.Configuration;

// Register services in DI
#region database services

//// use in-memory database
//builder.Services.AddDbContext<AspnetRunContext>(c =>
//    c.UseInMemoryDatabase("PolycartConnection"));

// add database dependency
builder.Services.AddDbContext<AspnetRunContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PolyCartConnection")));

#endregion            

#region project services

// add repository dependency
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICartRepository, CartRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();

#endregion

builder.Services.AddRazorPages();

var app = builder.Build();

// Seed database
SeedDatabase(app);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

static void SeedDatabase(WebApplication app)
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var loggerFactory = services.GetRequiredService<ILoggerFactory>();

        try
        {
            var aspnetRunContext = services.GetRequiredService<AspnetRunContext>();
            AspnetRunContextSeed.SeedAsync(aspnetRunContext, loggerFactory).Wait();
        }
        catch (Exception exception)
        {
            var logger = loggerFactory.CreateLogger("main");
            logger.LogError(exception, "An error occurred seeding the DB.");
        }
    }
}