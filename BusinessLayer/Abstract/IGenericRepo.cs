using CoreLayer.Utilitis.Result;
using CoreLayer.Utilitis.Result.DataResult;

namespace BusinessLayer.Abstract
{
    public interface IGenericRepo<T>
    {
        IDataResult<string> insert(T entity);
        IDataResult<string> update(T entity);
        IResult delete(string id);
        IDataResult<List<T>> get();
        IDataResult<List<T>> getByid(string id);
    }
}
