using TelemetryPortal_MVC.Models;
using System.Collections;
using System.Linq.Expressions;
using TelemetryPortal_MVC.Data;

namespace TelemetryPortal_MVC.Repositories
{
    public class ClientRepository : InterfaceClientRepository
    {
        private readonly TechtrendsContext _context;

        public ClientRepository(TechtrendsContext context)
        {
            _context = context;
        }
        public void Add(Client entity)
        {
            _context.Clients.Add(entity);  // Use _context to add the entity to the database
            _context.SaveChanges();
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public Client GetClientById(Guid? id)
        {
            var client = GetAll().FirstOrDefault(x => x.ClientId == id);

            if (client == null)
            {
                throw new InvalidOperationException($"Project with ID {id} not found.");
            }

            return client;
        }

        public void Remove(Client entity)
        {
            _context.Clients.Remove(entity);  // Remove the entity using _context
            _context.SaveChanges();
        }

        public void Update(Client entity)
        {
            _context.Clients.Update(entity);  // Update the entity using _context
            _context.SaveChanges();
        }
       
    }

}
