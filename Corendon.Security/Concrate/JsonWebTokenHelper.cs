using Corendon.Data.Entity.Abstract.User;
using Corendon.Security.Abstract;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Corendon.Security.Concrate
{
    public class JsonWebTokenHelper : IJsonWebTokenHelper
    {
        private readonly IConfiguration _configuration;

        public JsonWebTokenHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateJsonWebToken(IUserEntity user)
        {
            SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["AuthSettings:Secret"]));

            var dateTimeNow = DateTime.UtcNow;

            JwtSecurityToken jwt = new JwtSecurityToken(
                    issuer: _configuration["AuthSettings:ValidIssuer"],
                    audience: _configuration["AuthSettings:ValidAudience"],
                    claims: new List<Claim> {
                    new Claim("Id", user.GetId().ToString()),
                    new Claim("UserType", user.GetUserType().ToString())
                    },
                    notBefore: dateTimeNow,
                    expires: dateTimeNow.Add(TimeSpan.FromMinutes(500)),
                    signingCredentials: new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256)
                );

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}
