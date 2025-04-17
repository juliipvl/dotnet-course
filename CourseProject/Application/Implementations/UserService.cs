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
        public void ChangePassword(Guid userId, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void ChangeUser(Guid userId, string newUsername)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(Guid userId)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(Func<Guid, bool> func)
        {
            return _repository.GetAll().FirstOrDefault(user => func(user.Id));
        }

        public void Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Logout(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void Register(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
