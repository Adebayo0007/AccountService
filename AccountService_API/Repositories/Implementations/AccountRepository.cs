using AccountService_API.Entities;
using AccountService_API.Repositories.Interfaces;

namespace AccountService_API.Repositories.Implementations
{
    public class AccountRepository : IAccountRepository
    {
        public Task<bool> CreateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> DeactivatedUsers(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exist(string email, int appNumber)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllCustomers(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUnVerifiedUsers(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetByEmail(string email, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetModelByEmailAsync(string email, int appNumber)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetModelByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetModelByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
