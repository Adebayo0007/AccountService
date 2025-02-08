using AccountService_API.Entities;
using AccountService_API.Repositories.Interfaces;

namespace AccountService_API.Repositories.Implementations
{
    public class RoleRepository : IRoleRepository
    {
        public Task<bool> CreateAsync(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Role>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Role>> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
