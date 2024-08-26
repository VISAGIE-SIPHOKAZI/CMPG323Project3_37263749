using TelemetryPortal_MVC.Models;
using TelemetryPortal_MVC.Data;
using System.Collections;
using System.Linq.Expressions;


namespace TelemetryPortal_MVC.Repositories
{
    public class ProjectRepository : InterfaceProjectRepository
    {

        private readonly TechtrendsContext _context;

        public ProjectRepository(TechtrendsContext context)
        {
            _context = context;
        }

        public void Add(Project entity)
        {
            _context.Projects.Add(entity);  // Use _context to add the entity to the database
            _context.SaveChanges();
        }

        public IEnumerable<Project> GetAll()
        {
            return _context.Projects.ToList();
        }

        public Project GetProjectById(Guid? id)
        {
            var project = _context.Projects.FirstOrDefault(x => x.ProjectId == id);  // Retrieve the project using _context

            if (project == null)
            {
                throw new InvalidOperationException($"Project with ID {id} not found.");
            }

            return project;
        }

        public void Remove(Project entity)
        {
            _context.Projects.Remove(entity);  // Remove the entity using _context
            _context.SaveChanges();
        }

        public void Update(Project entity)
        {
            _context.Projects.Update(entity);  // Update the entity using _context
            _context.SaveChanges();
        }

       
    }
}
