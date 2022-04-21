using Microsoft.IdentityModel.Tokens;

namespace CoreLayer.Utilitis.Security.JWT.Encription
{
    public class SigningCredentialHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, algorithm: SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
