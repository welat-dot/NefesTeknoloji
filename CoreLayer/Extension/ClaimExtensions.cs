using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CoreLayer.Extension
{
    public static class ClaimExtensions
    {
        public static void AddEmail(this ICollection<Claim> claims, string email)
        {
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, value: email));
        }
       
    }
}
