using CoreLayer.Extension;
using CoreLayer.Utilitis.Security.JWT.Encription;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CoreLayer.Utilitis.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration configuration { get; }
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;
        public JwtHelper(IConfiguration configuration)
        {
            this.configuration = configuration;
            _tokenOptions = configuration.GetSection("TokenOptions").Get<TokenOptions>();
        }
        public AccessToken CreateToken(string username)
        {
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialHelper.CreateSigningCredentials(securityKey);
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var jwt = CreateJwtSecurityToken(tokenOptions: _tokenOptions,signingCredentials: signingCredentials,username);
            var JwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = JwtSecurityTokenHandler.WriteToken(jwt);
            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration

            };
        }
        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions,SigningCredentials signingCredentials, string usernmae)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(usernmae),
                signingCredentials: signingCredentials
                );
            return jwt;
        }
        private IEnumerable<Claim> SetClaims(string username)
        {
            var claims = new List<Claim>();
            claims.AddEmail(username);
            return claims;
        }
    }
}
