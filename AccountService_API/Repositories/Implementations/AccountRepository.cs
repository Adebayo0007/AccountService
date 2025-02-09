using AccountService_API.ApplicationContext;
using AccountService_API.Entities;
using AccountService_API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AccountService_API.Repositories.Implementations
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDBContext _db;
        public AccountRepository(ApplicationDBContext db)
        {
            _db = db;
        }
        public async Task<bool> CreateAsync(User entity)
        {
            if (entity == null) throw new ArgumentNullException();
            var response = await _db.Users.AddAsync(entity);
            if (response.Entity == null) return false;
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<User>> DeactivatedUsers(CancellationToken cancellationToken = default)
        {
            return await _db.Users
              .Where(x => x.IsDeleted == true)
              .OrderByDescending(x => x.DateCreated)
             .ToListAsync(cancellationToken);
        }

        public async Task DeleteAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<bool> Exist(string email)
        {
            return await _db.Users.AnyAsync(x => x.Email.ToLower() == email.ToLower());
        }
        public async Task<User> FindUserAsync(string name, string password)
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
