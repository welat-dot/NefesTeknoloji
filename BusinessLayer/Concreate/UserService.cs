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

        public IDataResult<User> checkUserByMail(string mail)
        {

            try
            {
                List<User> user = userManager.select(x => x.EmailAdress.Equals(mail));
                return user.Count == 0 ?
                    new ErrorDataResult<User>("Kullanıcı Bulunamdı ", new User()) :
                    new SuccessDataResult<User>("", user[0]);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<User>(e.Message,new User()
                {
                    EmailAdress="-1",

                });
            }
        }

        public override IResult delete(string id)
        {
            
            try
            {
                List<User> user = userManager.select(x => x.Id.Equals(id));
                return user.Count == 0 ?
                    new ErrorResult("Kullanıcı Bulunamdı ") :
                    userManager.delete(user[0]) == null ?
                        new ErrorResult("Kullanıcı Bulunamdı ") :
                        new SuccessResult("kullanıcı silindi");
            }
            catch (Exception e)
            {

                return new ErrorResult(e.Message);
            }
        }

        public override IDataResult<List<User>> get()
        {
            try
            {
                List<User> users = userManager.selectAll().ToList();
                return users == null ?
                    new ErrorDataResult<List<User>>("Kullanıcı Bulunamdı ", new List<User>()) :
                    new SuccessDataResult<List<User>>("", users);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<List<User>>(e.Message, new List<User>());
            }
        }

        public override IDataResult<List<User>> getByid(string id)
        {
            try
            {
                List<User> users = userManager.select(x => x.Id.Equals(id)).ToList();
                return users == null ?
                    new ErrorDataResult<List<User>>("Kullanıcı Bulunamdı ", new  List<User>()) :
                    new SuccessDataResult<List<User>>("", users);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<List<User>>(e.Message, new List<User>());
            }
            
        }

        public override IDataResult<string> insert(User entity)
        {
            try
            {
                entity.Id=Guid.NewGuid().ToString();
                User user = userManager.insert(entity);
                return user == null ?
                    new ErrorDataResult<string>("Kullanıcı Kayıt Edilmedi", "") :
                    new SuccessDataResult<string>("Kullanıcı Kaydı Başarılı", user.EmailAdress);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<string>(e.Message);
            }


        }

        public override IDataResult<string> update(User entity)
        {
            try
            {
                User user = userManager.update(entity);
                return user == null ?
                     new ErrorDataResult<string>("Kullanıcı Kayıt Edilmedi", "") :
                     new SuccessDataResult<string>("Kullanıcı Kaydı Başarılı", user.EmailAdress);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<string>(e.Message);
            }
           
        }
        
    }
}
