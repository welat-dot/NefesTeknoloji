using CoreLayer.Utilitis.Result.DataResult;
using EntityLayer;

namespace BusinessLayer.Abstract
{
    public interface IPersonelService : IGenericRepo<Personel>
    {
        IDataResult<List<Personel>> GetAllJoin();
    }
}
