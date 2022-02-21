using RepositoryDesignAPI.Models;
using System.Collections.Generic;

namespace RepositoryDesignAPI.Contracts
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments(bool trackChanges);
        void CreateDepartment(Department department);
    }
}
