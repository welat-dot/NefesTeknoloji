using CoreLayer.Utilitis.Result;
using EntityLayer;

namespace BusinessLayer.Abstract
{
    public interface IAuthService
    {
        IResult Login(LoginDTO login);
        IResult Register(LoginDTO login);
    }
}
