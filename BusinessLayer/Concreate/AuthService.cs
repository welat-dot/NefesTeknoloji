using BusinessLayer.Abstract;
using CoreLayer.Utilitis.Result;
using CoreLayer.Utilitis.Result.DataResult;
using CoreLayer.Utilitis.Security.Hashing;
using CoreLayer.Utilitis.Security.JWT;
using EntityLayer;
using Newtonsoft.Json;

namespace BusinessLayer.Concreate
{
    public class AuthService : IAuthService
    {

        private IUserService userService;
        private ITokenHelper tokenHelper;

        public AuthService(IUserService userService, ITokenHelper tokenHelper)
        {
            this.userService = userService;
            this.tokenHelper = tokenHelper;
        }
        public IResult Login(LoginDTO login)
        {
            IDataResult<User> result = userService.checkUserByMail(login.mail);
            if (!result.success)
                return new ErrorResult("Doğrulama Hatası");
            if (HashingHelper.VerifityPasswordHash(login.pasword, result.data.PasswordHash, result.data.PasswordSalt))
                return new SuccessResult(JsonConvert.SerializeObject(
                                         tokenHelper.CreateToken(login.mail == null ? 
                                         "" : login.mail)));

            return new ErrorResult("Doğrulama Hatası");

        }

        public IResult Register(LoginDTO login)
        {
            IDataResult<User> result = userService.checkUserByMail(login.mail);
            if (result.success)
                return new ErrorResult("Email Adresi Zaten Kullanılıyor");
            if(!result.success&&result.data.EmailAdress.Equals("-1"))
                return new ErrorResult(result.message);
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreateHash(login.pasword, out passwordHash, out passwordSalt);

            IDataResult<string> result1 = userService.insert(new User
            {
                EmailAdress=login.mail,
                Id = Guid.NewGuid().ToString(),
                PasswordHash=passwordHash,
                PasswordSalt=passwordSalt
            });
            return new Result(result1.success, result1.data + " " + result1.message);
           
        }
    }
}
