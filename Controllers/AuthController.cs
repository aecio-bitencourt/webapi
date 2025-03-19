using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using API.Data;
using API.Models;
using System.Security.Claims;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly ApplicationDBContext _context;

    public AuthController(IConfiguration configuration, ApplicationDBContext context)
    {
        _configuration = configuration;
        _context = context;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] Usuarios loginDto)
    {
        var user = await _context.Usuarios
            .FirstOrDefaultAsync(u => u.Nome == loginDto.Nome);

        if (user == null || user.senha != loginDto.senha) // Substitua isso por hash de senha
        {
            return Unauthorized("Usuário ou senha inválidos.");
        }

        var allowedUsers = new List<string> {"otavio_ti", "Aecio"};

        if (!allowedUsers.Contains(user.Nome))
        {
            return Unauthorized("Você não tem permissão para acessar a API");
        }

        var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Nome),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

        var jwtSettings = _configuration.GetSection("JwtSettings");
        var secretKey = Encoding.UTF8.GetBytes(jwtSettings["Secret"]);

        var token = new JwtSecurityToken(
            issuer: jwtSettings["Issuer"],
            audience: jwtSettings["Audience"],
            expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(jwtSettings["ExpirationMinutes"])),
            claims: claims,
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256)
        );

        return Ok(new
        {
            token = new JwtSecurityTokenHandler().WriteToken(token),
            Expiration = token.ValidTo
        });
    }
}