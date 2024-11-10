using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using department_system.DataAccess.Entities;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace department_system.Business.Helpers;

public static class JwtHelper
{
	public static string GenerateToken(Student user, IConfiguration configuration)
	{
		var secretKey = configuration.GetValue<string>("JwtConfiguration:SecretKey");

		var key = Encoding.ASCII.GetBytes(secretKey);

		var tokenHandler = new JwtSecurityTokenHandler();

		var tokenDescriptor = new SecurityTokenDescriptor
		{
			Subject = new ClaimsIdentity(new[]
			{
				new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
				new Claim(ClaimTypes.Name, user.Name)
			}),
			Expires = DateTime.Now.AddDays(1),
			SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
		};

		var token = tokenHandler.CreateToken(tokenDescriptor);

		return tokenHandler.WriteToken(token);
	}
}
