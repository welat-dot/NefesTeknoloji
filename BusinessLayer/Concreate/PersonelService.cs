using BusinessLayer.Abstract;
using CoreLayer.Utilitis.Result;
using CoreLayer.Utilitis.Result.DataResult;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class PersonelService : GenericRepo<Personel>, IPersonelService
    {
        public override IResult delete(string id)
        {
            return base.delete(id);
        }

        public override IDataResult<IQueryable<Personel>> get()
        {
            return base.get();
        }

        public override IDataResult<IQueryable<Personel>> getByid(string id)
        {
            return base.getByid(id);
        }

        public override IDataResult<Personel> insert(Personel entity)
        {
            return base.insert(entity);
        }

        public override IDataResult<Personel> update(Personel entity)
        {
            return base.update(entity);
        }
    }
}
