using BusinessLayer.Abstract;
using CoreLayer.Utilitis.Result;
using CoreLayer.Utilitis.Result.DataResult;
using DataLayer.Abstarct;
using EntityLayer;

namespace BusinessLayer.Concreate
{
    public class UserService : GenericRepo<User>, IUserService
    {
        private IUserManager userManager;

        public UserService(IUserManager userManager)
        {
            this.userManager = userManager;  
        }
        public override IResult delete(string id)
        {
            return base.delete(id);
        }
        public override IDataResult<IQueryable<User>> get()
        {
            return base.get();
        }

        public override IDataResult<IQueryable<User>> getByid(string id)
        {
            return base.getByid(id);
        }

        public override IDataResult<User> insert(User entity)
        {

           userManager.insert(entity);
           return base.insert(entity);
        }

        public override IDataResult<User> update(User entity)
        {
            return base.update(entity);
        }
    }
}
