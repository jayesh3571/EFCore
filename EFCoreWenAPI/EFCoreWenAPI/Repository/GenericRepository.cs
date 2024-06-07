using EFCoreWenAPI.Interface;

namespace EFCoreWenAPI.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public Task<T> AddEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
