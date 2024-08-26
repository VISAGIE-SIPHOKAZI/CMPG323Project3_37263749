using System.Collections;
using System.Linq.Expressions;
using TelemetryPortal_MVC.Data;

namespace TelemetryPortal_MVC.Repositories
{
    public class GenericRepository<T> : InterfaceGenericRepository<T> where T : class
    {
        protected readonly TechtrendsContext _context;
        public GenericRepository(TechtrendsContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Add)} entity must not be null");
            }
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public IEnumerable<T> GetAll()
        {

            try
            {
                return _context.Set<T>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not retrieve entities: {ex.Message}");
            }
        }

        public void Remove(T entity)
        {
            try
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not be remove entity: {ex.Message}");
            }
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Add)} entity must not be null");
            }
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException($"{nameof(entity)} could not be updated: {ex.Message}");
            }


        }
      
    }
}
