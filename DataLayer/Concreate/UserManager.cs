using CoreLayer.DataAccess;
using DataLayer.Abstarct;
using DataLayer.Context;
using EntityLayer;

namespace DataLayer.Concreate
{
    public class UserManager : BaseRepository<User, NefesContext>,IUserManager
    {
        private NefesContext dBContext;
        public UserManager(NefesContext dBContext) : base(dBContext)
        {
            this.dBContext = dBContext;
        }
    }
}
