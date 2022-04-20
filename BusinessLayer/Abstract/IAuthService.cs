using CoreLayer.Utilitis.Result;

namespace BusinessLayer.Abstract
{
    public interface IAuthService
    {
        Result Login();
        Result Register();
    }
}
