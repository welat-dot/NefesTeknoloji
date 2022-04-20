using CoreLayer.Utilitis.Result;
using CoreLayer.Utilitis.Result.DataResult;

namespace BusinessLayer.Abstract
{
    public interface IGenericRepo<T>
    {
        IDataResult<T> insert(T entity);
        IDataResult<T> update(T entity);
        IResult delete(string id);
        IDataResult<IQueryable<T>> get();
        IDataResult<IQueryable<T>> getByid(string id);
    }
}
