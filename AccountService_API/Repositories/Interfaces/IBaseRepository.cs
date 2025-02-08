namespace AccountService_API.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<bool> CreateAsync(T entity);
        Task<IEnumerable<T>> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity);
        Task DeleteAsync();
    }
}
