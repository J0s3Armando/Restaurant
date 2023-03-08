using Microsoft.IdentityModel.Tokens;
using Restaurant.Entity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Restaurant.API.Utils.jwt
{
    public class JwtConfiguration
    {
        private readonly IConfiguration _config;
        public JwtConfiguration(IConfiguration config) {
            _config = config;
        }
        public string GenerateToket(User user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["jwt:key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Role, user.Idrol.ToString()),
                new Claim(ClaimTypes.Email, user.Email)
            };

            var token = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddMinutes(10),signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
