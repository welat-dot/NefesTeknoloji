using CoreLayer.DataAccess;
using DataLayer.Abstarct;
using DataLayer.Context;
using EntityLayer;

namespace DataLayer.Concreate
{
    public class PersonelManager : BaseRepository<Personel, NefesContext>,IPersonelManager
    {
    }
}
