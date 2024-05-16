using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NZWalksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        // TODO: Do not store this here
        private const string secret = "pommeazertyuiopqsdfghjklmwxcvbnpommeazertyuiopqsdfghjklmwxcvbnpommeazertyuiopqsdfghjklmwxcvbn";

        private string CreateJWTToken(string[] roles)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.UTF8.GetBytes(secret);

            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(JwtRegisteredClaimNames.Email, "foo@bar.com"),
                new(JwtRegisteredClaimNames.Name, "Jos de magazijnier"),
                new("userId", "-1")
            };

            foreach (string role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = "http://localhost:5162/",
                Audience = "http://localhost:5162/",
                SigningCredentials = new SigningCredentials
                (
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256

                )
            };

            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            string jwt = tokenHandler.WriteToken(token);

            return jwt;

        }

        [HttpGet]
        public ActionResult Login(string[] roles)
        {
            return Ok(CreateJWTToken(roles));
        }
    }
}
