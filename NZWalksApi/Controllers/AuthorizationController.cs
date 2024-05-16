using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
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
        private const string secret = "pommeazertyuiopqsdfghjklmwxcvbnpommeazertyuiopqsdfghjklmwxcvbnpommeazertyuiopqsdfghjklmwxcvbn";


        private string CreateJWTToken()
        {
            var tokenHandler  = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(secret);

            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(JwtRegisteredClaimNames.Sub, "foo@bar.com"),
                new(JwtRegisteredClaimNames.Email, "foo@bar.com"),
                new("userId", "-1")
            };

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
        public ActionResult Login()
        {
            return Ok(CreateJWTToken());
        }
    }
}
