using TelemetryPortal_MVC.Models;
using System.Collections;
using System.Linq.Expressions;
using System;

namespace TelemetryPortal_MVC.Repositories
{
    public interface InterfaceProjectRepository : InterfaceGenericRepository<Project>
    {
        Project GetProjectById(Guid? id); // Retrieve a project by its ID
    }
    
}
