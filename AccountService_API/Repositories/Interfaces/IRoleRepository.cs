using AccountService_API.Entities;

namespace AccountService_API.Repositories.Interfaces
{
    public interface IRoleRepository : IBaseRepository<Role>
    {
        Task<Role> GetModelByIdAsync(string id);
        Task<Role> FindByNameAsync(string name);
        Task<bool> RoleExistsAsync(string roleName);
    }
}
