using BusinessLayer.Abstract;
using CoreLayer.Utilitis.Result;
using CoreLayer.Utilitis.Result.DataResult;
using EntityLayer;

namespace BusinessLayer.Concreate
{
    public class BirimService : GenericRepo<Birim>, IBirimService
    {
        public override IResult delete(string id)
        {
            return base.delete(id);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override IDataResult<IQueryable<Birim>> get()
        {
            return base.get();
        }

        public override IDataResult<IQueryable<Birim>> getByid(string id)
        {
            return base.getByid(id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override IDataResult<Birim> insert(Birim entity)
        {
            return base.insert(entity);
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public override IDataResult<Birim> update(Birim entity)
        {
            return base.update(entity);
        }
    }
}
