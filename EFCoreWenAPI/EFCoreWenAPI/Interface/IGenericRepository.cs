namespace EFCoreWenAPI.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(string id);        
        Task<T> AddEntity(T entity);
        Task<T> UpdateEntity(T entity);
        Task<T> DeleteEntity(int id);
    }
}
