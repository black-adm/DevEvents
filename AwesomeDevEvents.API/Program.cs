using AwesomeDevEvents.API.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DevEventsCs");

builder.Services.AddDbContext<DevEventDbContext>(o => o.UseSqlServer(connectionString));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(a =>
{
    a.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "DevEvents.API",
        Version = "v1",
        Contact = new OpenApiContact
        {
            Name = "Matheus Roberto Madureira",
            Email = "matheus.dotnet@outlook.com",
            Url = new Uri("https://br.linkedin.com/in/matheus-roberto-240726292")
        }
    });

    var xmlFile = "DevEvents.API.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    a.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
