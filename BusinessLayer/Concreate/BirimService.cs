using BusinessLayer.Abstract;
using CoreLayer.Utilitis.Result;
using CoreLayer.Utilitis.Result.DataResult;
using DataLayer.Abstarct;
using EntityLayer;

namespace BusinessLayer.Concreate
{
    public class BirimService : GenericRepo<Birim>, IBirimService
    {
        private readonly IBirimManager  birimManager;

        public BirimService(IBirimManager birimManager)
        {
            this.birimManager = birimManager;
        }
        public override IResult delete(string id)
        {
            try
            {
                List<Birim> birims = birimManager.select(x => x.Id.Equals(id));
                return birims.Count == 0 ?
                    new ErrorResult("Kayıt Bulunamadı") :
                    birimManager.delete(birims[0]) == null ?
                            new ErrorResult("Kayıt Silinemedi ") :
                            new SuccessResult("Kayıt silindi");
            }
            catch (Exception e)
            {

                return new ErrorResult(e.Message);
            }


            
        }

        public override IDataResult<List<Birim>> get()
        {
            try
            {
                List<Birim> birims = birimManager.selectAll();
                return birims.Count == 0 ?
                    new ErrorDataResult<List<Birim>>("Kayıt Bulunamadı", new List<Birim>()) :
                    new SuccessDataResult<List<Birim>>("", birims);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<List<Birim>>(e.Message, new List<Birim>());
            }
        }

        public override IDataResult<List<Birim>> getByid(string id)
        {
            try
            {
                List<Birim> birims = birimManager.select(x => x.Id.Equals(id));
                return birims.Count == 0 ?
                   new ErrorDataResult<List<Birim>>("Kayıt Bulunamadı", new List<Birim>()) :
                   new SuccessDataResult<List<Birim>>("", birims);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<List<Birim>>(e.Message, new List<Birim>());
            }

        }

        public override IDataResult<string> insert(Birim entity)
        {
            try
            {
                entity.Id = Guid.NewGuid().ToString(); 
                Birim birim = birimManager.insert(entity);
                return string.IsNullOrEmpty(birim.Id.ToString()) ?
                     new ErrorDataResult<string>("Kayıt işlemi Başarısız", "") :
                     new SuccessDataResult<string>(birim.Id.ToString());
            }
            catch (Exception e)
            {

                return new ErrorDataResult<string>("Kayıt işlemi Başarısız", e.Message);
            }
        }

        public override IDataResult<string> update(Birim entity)
        {
            try
            {
                Birim birim = birimManager.update(entity);
                return string.IsNullOrEmpty(birim.Id.ToString()) ?
                     new ErrorDataResult<string>("Kayıt işlemi Başarısız", "") :
                     new SuccessDataResult<string>(birim.Id.ToString());
            }
            catch (Exception e)
            {

                return new ErrorDataResult<string>("Kayıt işlemi Başarısız", e.Message);
            }
        }
    }
}
