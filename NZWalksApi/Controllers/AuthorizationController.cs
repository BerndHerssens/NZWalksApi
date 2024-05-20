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
        //Do not do this cool thing!
        private string key = "pommeazertyuiopqsdfghjklmwxcvbnpommeazertyuiopqsdfghjklmwxcvbnpommeazertyuiopqsdfghjklmwxcvbn";
        private string CreateJWTToken(string[] roles)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            Byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            //Hier voegen we informatie over de gebruiker (claims) toe
            //Vanaf hier tot en met lijn 37 is te configureren
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, "Jos@magazijn.com"));
            claims.Add(new Claim(JwtRegisteredClaimNames.Name, "Jos De Magazijnier"));
            claims.Add(new Claim("Hobby", "Dozen verslepen"));
            
            foreach (string role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor();
            tokenDescriptor.Subject = new ClaimsIdentity(claims);
            tokenDescriptor.Expires = DateTime.UtcNow.AddHours(1);
            tokenDescriptor.Audience = "http://localhost:5162/";
            tokenDescriptor.Issuer = "http://localhost:5162/";
            tokenDescriptor.SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(keyBytes),
                SecurityAlgorithms.HmacSha256
                );

            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            
            return tokenHandler.WriteToken(token);
        }

        [HttpGet]
        public ActionResult Login(string[] roles)
        {
            return Ok(CreateJWTToken(roles));
        }
    }
}
