using Core.Models;
using Application.Abstractions;

namespace Application.Implementations
{
    public class UserService : IUserService
    {
        public void ChangePassword(long userId, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void ChangeUser(long userId, string newUsername)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(long userId)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(Func<long, bool> func)
        {
            return new List <User>().Find((user) => func(user.Id));
        }

        public void Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Logout(long userId)
        {
            throw new NotImplementedException();
        }

        public void Register(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
