using CoreLayer.DataAccess;
using CoreLayer.Utilitis.Result.DataResult;
using EntityLayer;

namespace DataLayer.Abstarct
{
    public interface IPersonelManager : IBaseRepository<Personel>
    {
        List<Personel> selectjoin();
    }
}
