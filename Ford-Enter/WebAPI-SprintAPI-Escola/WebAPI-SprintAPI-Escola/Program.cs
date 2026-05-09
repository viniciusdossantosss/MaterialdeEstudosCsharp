using Microsoft.EntityFrameworkCore;
using WebAPI_SprintAPI_Escola.Data;

var builder = WebApplication.CreateBuilder(args);


// Pegamos a string de conexão lá do appsettings.json
var connectionString = builder.Configuration.GetConnectionString("ConexaoPadrao");

// Avisamos ao ASP.NET: "Sempre que alguém precisar do AppDbContext, crie um usando o MySQL"
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddMaps(typeof(Program).Assembly);
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
