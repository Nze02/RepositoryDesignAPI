namespace RepositoryDesignAPI.Contracts
{
    public interface IRepositoryManager
    {
        IDepartmentRepository Department { get; }
        IStudentRepository Student { get; }
        void Save();
    }
}
