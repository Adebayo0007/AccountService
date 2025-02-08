using AccountService_API.Entities;

namespace AccountService_API.Repositories.Interfaces
{
    public interface IAccountRepository : IBaseRepository<User>
    {
        Task<User> GetModelByEmailAsync(string email, int appNumber);
        Task<User> GetModelByEmailAsync(string email);
        Task<User> GetModelByIdAsync(string id);
        Task<bool> Exist(string email, int appNumber);
        Task<IEnumerable<User>> DeactivatedUsers(CancellationToken cancellationToken = default);
        Task<IEnumerable<User>> GetAllUnVerifiedUsers(CancellationToken cancellationToken = default);
        Task<IEnumerable<User>> GetAllCustomers(CancellationToken cancellationToken = default);
        Task<IEnumerable<User>> GetByEmail(string email, CancellationToken cancellationToken = default);
    }
}
