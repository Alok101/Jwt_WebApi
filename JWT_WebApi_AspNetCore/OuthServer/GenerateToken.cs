using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace OuthServer
{
    public class GenerateToken
    {
        private string key = "tUB38cEJIoZsgtr3MMu3C5SzJYKfXAaKInaobHXWXdlUT9qzUJmxCaH3mgD3X99";
        public string GenerateJwtToken(string userId)
        {
            if (userId == null)
                return null;
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.Name, userId) }),
                Expires = DateTime.Now.AddMinutes(120),
                SigningCredentials = credentials
            };
            var token = new JwtSecurityTokenHandler().CreateToken(tokenDescriptor);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
