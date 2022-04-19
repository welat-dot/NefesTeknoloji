namespace CoreLayer.DataAccess
{
    public interface IBaseRepository<TData> where TData:IEntity,class,new()
    {
        
    }
    
}