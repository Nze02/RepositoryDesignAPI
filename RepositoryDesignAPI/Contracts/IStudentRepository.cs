using RepositoryDesignAPI.Models;
using System.Collections.Generic;

namespace RepositoryDesignAPI.Contracts
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents(bool trackChanges);
        void CreateStudent(Student student);
    }
}
