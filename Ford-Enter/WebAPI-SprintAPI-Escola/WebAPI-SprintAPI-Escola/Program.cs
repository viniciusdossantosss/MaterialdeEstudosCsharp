using Microsoft.EntityFrameworkCore;
using WebAPI_SprintAPI_Escola.Data;
using WebAPI_SprintAPI_Escola.Repositories;
using WebAPI_SprintAPI_Escola.Services;

var builder = WebApplication.CreateBuilder(args);

// Pegamos a string de conexão lá do appsettings.json
var connectionString = builder.Configuration.GetConnectionString("ConexaoPadrao");

// Avisamos ao ASP.NET: "Sempre que alguém precisar do AppDbContext, crie um usando o MySQL"
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

// Registrar Repositórios
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();
builder.Services.AddScoped<ITurmaRepository, TurmaRepository>();
builder.Services.AddScoped<IDisciplinaRepository, DisciplinaRepository>();
builder.Services.AddScoped<IResponsavelRepository, ResponsavelRepository>();
builder.Services.AddScoped<INotaRepository, NotaRepository>();

// Registrar Serviços
builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<IProfessorService, ProfessorService>();
builder.Services.AddScoped<ITurmaService, TurmaService>();
builder.Services.AddScoped<IDisciplinaService, DisciplinaService>();
builder.Services.AddScoped<IResponsavelService, ResponsavelService>();
builder.Services.AddScoped<INotaService, NotaService>();

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddMaps(typeof(Program).Assembly);
});

// No .NET 9+, usamos o pacote nativo Microsoft.AspNetCore.OpenApi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // Mapeia o JSON do OpenAPI (ex: /openapi/v1.json)
    
    // Como a interface visual (Swashbuckle/SwaggerUI) está apresentando 
    // incompatibilidades com o .NET 10, você pode acessar a documentação via:
    // https://localhost:7123/openapi/v1.json
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();