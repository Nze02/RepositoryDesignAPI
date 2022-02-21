using RepositoryDesignAPI.Contracts;
using RepositoryDesignAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryDesignAPI.Repositories
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationContext ApplicationContext) : base(ApplicationContext)
        {

        }
        public IEnumerable<Student> GetAllStudents(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        public void CreateStudent(Student student) => Create(student);
    }
}
