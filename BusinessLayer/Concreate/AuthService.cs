using BusinessLayer.Abstract;
using CoreLayer.Utilitis.Result;
using CoreLayer.Utilitis.Security.Hashing;
using EntityLayer;

namespace BusinessLayer.Concreate
{
    public class AuthService : IAuthService
    {

        private IUserService userService;

        public AuthService(IUserService userService)
        {
            this.userService = userService;
        }
        public Result Login(string uname,string pasword)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreateHash("admin", out passwordHash, out passwordSalt);
            userService.insert(new User
            {
                Id = Guid.NewGuid(),
                EmailAdress = uname,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            });


        }

        public Result Register()
        {
            throw new NotImplementedException();
        }
    }
}
