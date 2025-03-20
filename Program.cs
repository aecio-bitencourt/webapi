using API.Data;
using API.Interfaces;
using API.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IOperacoesRepo, OperacoesRepository>();

builder.Services.AddControllers();

// Carregar configurações do JWT
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var secretKey = Encoding.UTF8.GetBytes(jwtSettings["Secret"] ?? throw new ArgumentNullException("JwtSettings:Secret não configurado!"));
var issuer = jwtSettings["Issuer"] ?? throw new ArgumentNullException("JwtSettings:Issuer não configurado!");
var audience = jwtSettings["Audience"] ?? throw new ArgumentNullException("JwtSettings:Audience não configurado!");

// Configuração da autenticação JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(secretKey),
            ValidateIssuer = true,
            ValidIssuer = issuer,
            ValidateAudience = true,
            ValidAudience = audience,
            ValidateLifetime = true, // Expiração do token
            ClockSkew = TimeSpan.Zero // Sem tolerância extra para expiração
        };
    });

builder.Services.AddAuthorization();

// Configuração do Swagger para JWT
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Description = "Autenticação JWT. Exemplo: \"Bearer SEU_TOKEN_AQUI\"",
        Name = "Authorization",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "bearer"
    });

    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

// Configuração do banco de dados
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Registro do repositório
builder.Services.AddScoped<IOperacoesRepo, OperacoesRepository>();

var app = builder.Build();

// Configuração do pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication(); // Ativa autenticação JWT
app.UseAuthorization();

app.MapControllers();

app.Run();