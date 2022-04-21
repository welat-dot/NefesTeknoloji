using CoreLayer.Interface;
using System.Linq.Expressions;

namespace CoreLayer.DataAccess
{
    public interface IBaseRepository<TData> where TData: class, IEntity,new()
    {
        TData insert(TData entity);
        TData update(TData entity);
        TData delete(TData entity);
        List<TData> select(Expression<Func<TData, bool>> filter);
        List<TData> selectAll();
    }
    
}