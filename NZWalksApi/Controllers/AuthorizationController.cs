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
        private string CreateJWTToken(IdentityUser identityUser, List<string> roles)
        {

            string secret = "pommeazertyuiopqsdfghjklmwxcvbnpommeazertyuiopqsdfghjklmwxcvbnpommeazertyuiopqsdfghjklmwxcvbn"; 
            string issuer = "http://localhost:5162/";
            string audience = "http://localhost:5162/";
            var claims = new List<Claim>();
            var Jos = new IdentityUser();
            Jos.Email = "foebar@gmail.com";
            roles = new List<string>();
            roles.Add("admin");
            claims.Add(new Claim(ClaimTypes.Email, Jos.Email)); //hier kijken we welke claims deze identityUser heeft

            foreach (var role in roles) //hier geven we hem dan de rollen aan de hand van zijn claims
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer,
                audience,
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return Ok(CreateJWTToken(null,null));
        }
    }
}
