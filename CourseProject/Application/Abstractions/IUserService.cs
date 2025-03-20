using Core.Models;

namespace Application.Abstractions
{
    public interface IUserService
    {
        void Register(string username, string password);

        void Login(string username, string password);

        void Logout(long userId);

        void ChangeUser(long userId, string newUsername);

        void ChangePassword(long userId, string newPassword);

        void DeleteAccount(long userId);

        User GetUserById(Func<long, bool> func); 
    }
}
