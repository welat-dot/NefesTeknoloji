using BusinessLayer.Abstract;
using CoreLayer.Utilitis.Result;
using CoreLayer.Utilitis.Result.DataResult;

namespace BusinessLayer.Concreate
{
    public class GenericRepo<T> : IGenericRepo<T>
    {
        public virtual IResult delete(string id)
        {
            throw new NotImplementedException();
        }

        public virtual IDataResult<IQueryable<T>> get()
        {
            throw new NotImplementedException();
        }

        public virtual IDataResult<IQueryable<T>> getByid(string id)
        {
            throw new NotImplementedException();
        }

        public virtual IDataResult<T> insert(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IDataResult<T> update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
