using CoreLayer.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CoreLayer.DataAccess
{
    public class BaseRepository<TData, TContext> : IBaseRepository<TData> where TData : class, IEntity, new()
        where TContext : DbContext, new()

    {
        private TContext dbContext;
        public BaseRepository(TContext Context)
        {

            dbContext = Context;
        }
        public TData delete(TData entity)
        {
           
                TData data = dbContext.Set<TData>().Remove(entity).Entity;
                dbContext.SaveChanges();
                return data;              
           
        }

        public TData insert(TData entity)
        {
          
                TData dd = dbContext.Set<TData>().Add(entity).Entity;
                dbContext.SaveChanges();
                return dd;
            
           
        }

        public List<TData> selectAll()
        {
            IQueryable<TData> datals= dbContext.Set<TData>();

            return datals.Any() ? datals.ToList() : new List<TData>();
            
        }

        public List<TData> select(Expression<Func<TData, bool>> filter)
        {
           
                IQueryable<TData> itemls =  dbContext.Set<TData>().Where(filter);
                
                return itemls.Any()? itemls.ToList():new List<TData>();
            
        }

        public TData update(TData entity)
        {
           
                TData dd = dbContext.Set<TData>().Update(entity).Entity;
                dbContext.SaveChanges();
                return dd;
          
        }
    }
}