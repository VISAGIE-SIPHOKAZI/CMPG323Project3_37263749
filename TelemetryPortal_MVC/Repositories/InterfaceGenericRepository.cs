namespace TelemetryPortal_MVC.Repositories
{
    public interface InterfaceGenericRepository<E> where E : class
    {
        IEnumerable<E> GetAll();
        void Add(E entity);
        void Remove(E entity);
        void Update(E entity);
    }
  
}
