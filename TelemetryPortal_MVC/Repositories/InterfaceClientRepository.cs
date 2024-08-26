using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repositories
{
    public interface InterfaceClientRepository : InterfaceGenericRepository<Client>
    {
        Client GetClientById(Guid? id);
    }
    
}
