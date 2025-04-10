using Core.Models;

namespace Application.Abstractions
{
    public interface IUserService
    {
        void Register(string username, string password);

        void Login(string username, string password);

        void Logout(Guid userId);

        void ChangeUser(Guid userId, string newUsername);

        void ChangePassword(Guid userId, string newPassword);

        void DeleteAccount(Guid userId);

        User GetUserById(Func<Guid, bool> func); 
    }
}
