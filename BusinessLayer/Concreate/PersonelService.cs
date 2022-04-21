using BusinessLayer.Abstract;
using CoreLayer.Utilitis.Result;
using CoreLayer.Utilitis.Result.DataResult;
using DataLayer.Abstarct;
using EntityLayer;

namespace BusinessLayer.Concreate
{
    public class PersonelService : GenericRepo<Personel>, IPersonelService
    {
        private IPersonelManager personelManager;

        public PersonelService(IPersonelManager personelManager)
        {
            this.personelManager = personelManager;
        }
        public override IResult delete(string id)
        {
            try
            {
                List<Personel> personels = personelManager.
                                            select(x => x.Id.Equals(id));
                return personels.Count == 0 ?
                    new ErrorResult("Kullanıcı Bulunamdı ") :
                    personelManager.delete(personels[0]) == null ?
                        new ErrorResult("Kullanıcı Bulunamdı ") :
                        new SuccessResult("kullanıcı silindi");
            }
            catch (Exception e)
            {

                return new ErrorResult(e.Message);
            }
        }

        public override IDataResult<List<Personel>> get()
        {
            try
            {
                List<Personel> personels = personelManager.selectAll();
                return personels.Count == 0 ?
                    new ErrorDataResult<List<Personel>>("Personeller Bulunamdı ", new List<Personel>()) :
                    new SuccessDataResult<List<Personel>>("", personels);
            }
            catch (Exception e)
            {

                return new  ErrorDataResult<List<Personel>>(e.Message, new List<Personel>());
            }
        }

        public IDataResult<List<Personel>> GetAllJoin()
        {
            List<Personel> personels = personelManager.selectjoin();
            return personels.Count == 0 ?
                new ErrorDataResult<List<Personel>>("Kullanıcı Bulunamadı", new List<Personel>()) :
                new SuccessDataResult<List<Personel>>("", personels);
        }

        public override IDataResult<List<Personel>> getByid(string id)
        {
            try
            {
                List<Personel> personels = personelManager.
                                            select(x => x.Id.Equals(id));
                return personels.Count == 0 ?
                    new ErrorDataResult<List<Personel>>("Kullanıcı Bulunamdı ",new List<Personel>()) :
                    new SuccessDataResult<List<Personel>>("",personels);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<List<Personel>>(e.Message, new List<Personel>());
            }
        }

        public override IDataResult<string> insert(Personel entity)
        {
            try
            {
                entity.Id = Guid.NewGuid().ToString();  
                Personel personel = personelManager.insert(entity);

                return personel == null ?
                   new ErrorDataResult<string>("Kullanıcı Kayıt Edilmedi", "") :
                   new SuccessDataResult<string>("Kullanıcı Kaydı Başarılı", personel.Id.ToString());

            }
            catch (Exception e)
            {

                return new ErrorDataResult<string>("Kullanıcı Kayıt Edilmedi", "");
            }
        }

        public override IDataResult<string> update(Personel entity)
        {
            try
            {
                //entity.Id=Guid.NewGuid().ToString();    
                Personel personel = personelManager.update(entity);
                return personel == null ?
                   new ErrorDataResult<string>("Kullanıcı Kayıt Edilmedi", "") :
                   new SuccessDataResult<string>("Kullanıcı Kaydı Başarılı", personel.Id.ToString());

            }
            catch (Exception e)
            {

                return new ErrorDataResult<string>("Kullanıcı Kayıt Edilmedi", "");
            }
        }

    }
}
