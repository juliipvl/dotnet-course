using Core.Models;
using Application.Abstractions;
using Core.IRepositories;

namespace Application.Implementations
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<User> GetUserById(Func<Guid, bool> func)
        {
            var users = await _repository.GetAllAsync();
            return users.FirstOrDefault(user => func(user.Id));
        }

        public Task ChangePassword(Guid userId, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task ChangeUser(Guid userId, string newUsername)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAccount(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task Logout(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task Register(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
