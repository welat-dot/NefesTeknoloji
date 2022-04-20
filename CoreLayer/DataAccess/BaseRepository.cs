using CoreLayer.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CoreLayer.DataAccess
{
    public class BaseRepository<TData, TContext> : IBaseRepository<TData> where TData : class, IEntity, new()
        where TContext : DbContext, new()

    {
        public TData delete(TData entity)
        {
            using (var dbContext = new TContext())
            {
                TData data = dbContext.Set<TData>().Remove(entity).Entity;
                dbContext.SaveChanges();
                return data;
               
            }
        }

        public TData insert(TData entity)
        {
            using (var dbContext = new TContext())
            {
                TData dd = dbContext.Set<TData>().Add(entity).Entity;
                dbContext.SaveChanges();
                return dd;
            }
        }

        public IQueryable<TData> selectAll()
        {
            using (var dbContext = new TContext())
            {                
                return dbContext.Set<TData>();
            }
        }

        public IQueryable<TData> select(Expression<Func<TData, bool>> filter)
        {
            using (var dbContext = new TContext())
            {
                IQueryable<TData> itemls =  dbContext.Set<TData>().Where(filter);
                return itemls;
            }
        }

        public TData update(TData entity)
        {
            using (var dbContext = new TContext())
            {
                TData dd = dbContext.Set<TData>().Update(entity).Entity;
                dbContext.SaveChanges();
                return dd;
            }
        }
    }
}