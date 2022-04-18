namespace LeaveManagementApp.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id); // READ by ID
        Task<List<T>> GetAllAsync(); // READ
        Task<T> AddAsync(T entity); // CREATE
        Task<bool> Exists(int id); //Check if exists
        Task DeleteAsync(int id); // DELETE by ID
        Task UpdateAsync(T entity); // UPDATE by ID    
    }
}
