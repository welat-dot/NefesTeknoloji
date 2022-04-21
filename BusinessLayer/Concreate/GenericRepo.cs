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

        public virtual IDataResult<List<T>> get()
        {
            throw new NotImplementedException();
        }

        public virtual IDataResult<List<T>> getByid(string id)
        {
            throw new NotImplementedException();
        }

        public virtual IDataResult<string> insert(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IDataResult<string> update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
