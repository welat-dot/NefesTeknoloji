using CoreLayer.Interface;
using Microsoft.EntityFrameworkCore;

namespace CoreLayer.DataAccess
{
    public class BaseRepository<TData,TContext>:IBaseRepository<TData>  where TData: class, IEntity,new()
        where TContext : DbContext,new()
    
    {
        
    }
}