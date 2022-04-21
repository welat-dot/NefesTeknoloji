using CoreLayer.Utilitis.Result;
using CoreLayer.Utilitis.Result.DataResult;
using EntityLayer;

namespace BusinessLayer.Abstract
{
    public interface IUserService : IGenericRepo<User>
    {
       IDataResult<User> checkUserByMail(string mail);

    }
}
