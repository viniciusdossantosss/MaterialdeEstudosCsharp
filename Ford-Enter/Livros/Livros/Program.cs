using Microsoft.EntityFrameworkCore;
using Livros.Data;
using Livros.Repositories;
using Livros.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("ConexaoPadrao");

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseMySql(connectionString, 
        ServerVersion.AutoDetect(connectionString)));

builder.Services.AddAutoMapper(cfg => 
{
    cfg.LicenseKey = "eyJhbGciOiJSUzI1NiIsImtpZCI6Ikx1Y2t5UGVubnlTb2Z0d2FyZUxpY2Vuc2VLZXkvYmJiMTNhY2I1OTkwNGQ4OWI0Y2IxYzg1ZjA4OGNjZjkiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJodHRwczovL2x1Y2t5cGVubnlzb2Z0d2FyZS5jb20iLCJhdWQiOiJMdWNreVBlbm55U29mdHdhcmUiLCJleHAiOiIxODA4Njk3NjAwIiwiaWF0IjoiMTc3NzIzMTE2MSIsImFjY291bnRfaWQiOiIwMTlkY2IzYWU5NTI3ZDk4YTA5MWJkZmIzYzc2ZDBjZSIsImN1c3RvbWVyX2lkIjoiY3RtXzAxa3E1a3B0N2VjOHBkZGNqbWQ5aHYwN3ZmIiwic3ViX2lkIjoiLSIsImVkaXRpb24iOiIwIiwidHlwZSI6IjIifQ.WUc5NBu39ZbF2a2inQjF1wbaRSVX9u5o8R6zlXomLxa3CvS-gLp6O_J3b64PDiFpvTXJMeW-XW2Gvrg6YO9-_a7CpBO8jOWucFpp1e8_fnqE3aIpf-XC5LEeMCRKtJBCxOb2RrkFklFpfrZY9EfQLjsFO6QSR5mt9wnlFDkouV72g_DuC4ktbgfJIPk5eOlYASKiDx3SNY31oJAvoIwa86x027RyTznvy6LQ_gtiiMbNJxCtoCQK26EUH6xdbOj_EF1quxaCD3shos0ZnUuu1oRbm6rlVbtpu0xKcyhq8AUGevBp1hkMxxIXuPCCN6In14gMX3QQoUIBzJCGb-A-Dw";
}, AppDomain.CurrentDomain.GetAssemblies());

// Registro do repositorio
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<ILivroService, LivroService>();

builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"]
    };
});

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Bearer{seu token}"
    });
    
    c.AddSecurityRequirement(new OpenApiSecurityRequirement(
    {
        new OpenApiSecurityScheme
        {
            Refence = new OpenApiSecurityScheme
            {
                Type = Ref
            }
        }
    }));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
