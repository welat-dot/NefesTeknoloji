using CoreLayer.DataAccess;
using CoreLayer.Utilitis.Result.DataResult;
using DataLayer.Abstarct;
using DataLayer.Context;
using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Concreate
{
    public class PersonelManager : BaseRepository<Personel, NefesContext>,IPersonelManager
    {
        private NefesContext dBContext;
        public PersonelManager(NefesContext dBContext) : base(dBContext)
        {
            this.dBContext = dBContext;
        }

        public List<Personel> selectjoin()
        {
           IQueryable<Personel> personels= dBContext.Personel.Include(p => p.Birim);
            if (personels.Any())
                return personels.ToList();
            return new List<Personel>();

        }
    }
}
