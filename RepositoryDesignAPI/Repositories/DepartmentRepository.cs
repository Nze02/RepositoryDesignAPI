using RepositoryDesignAPI.Contracts;
using RepositoryDesignAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryDesignAPI.Repositories
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ApplicationContext ApplicationContext) : base(ApplicationContext)
        {
            
        }
        public IEnumerable<Department> GetAllDepartments(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        public void CreateDepartment(Department department) => Create(department);
    }
}
