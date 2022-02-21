using RepositoryDesignAPI.Contracts;

namespace RepositoryDesignAPI.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private ApplicationContext _applicationContext;
        private IDepartmentRepository _departmentRepository;
        private IStudentRepository _studentRepository;

        public RepositoryManager(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public IDepartmentRepository Department
        {
            get
            {
                if (_departmentRepository == null)
                    _departmentRepository = new DepartmentRepository(_applicationContext);
                return _departmentRepository;
            }
        }

        public IStudentRepository Student
        {
            get
            {
                if (_studentRepository == null)
                    _studentRepository = new StudentRepository(_applicationContext);
                return _studentRepository;
            }
        }

        public void Save() => _applicationContext.SaveChanges();
    }
}
