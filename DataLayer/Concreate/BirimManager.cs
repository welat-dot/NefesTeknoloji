using CoreLayer.DataAccess;
using DataLayer.Abstarct;
using DataLayer.Context;
using EntityLayer;

namespace DataLayer.Concreate
{
    public class BirimManager:BaseRepository<Birim,NefesContext>,IBirimManager
    {
        private NefesContext dBContext;
        public BirimManager(NefesContext dBContext) : base(dBContext)
        {
            this.dBContext = dBContext;
        }
    }
}
