using Domain.Models;
using ExternalResources.Services;
using Microsoft.EntityFrameworkCore;
using Repository.Database;
using Repository.Interfaces;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
});

// Services
builder.Services.Configure<HttpSettings>(builder.Configuration.GetSection("HttpSettings"));
builder.Services.AddScoped<IAnimeRepository, AnimeRepository>();
builder.Services.AddScoped<IHttpService, HttpService>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());

// Database
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString, x => x.MigrationsAssembly("Repository")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}

app.UseAuthorization();
app.UseCors(c => c.AllowAnyHeader()
                .AllowAnyOrigin()
                .AllowAnyMethod());

app.MapControllers();

app.Run();
