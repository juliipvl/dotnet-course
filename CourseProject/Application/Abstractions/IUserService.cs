using Core.Models;

namespace Application.Abstractions
{
    public interface IUserService
    {
        Task Register(string username, string password);

        Task Login(string username, string password);

        Task Logout(Guid userId);

        Task ChangeUser(Guid userId, string newUsername);

        Task ChangePassword(Guid userId, string newPassword);

        Task DeleteAccount(Guid userId);

        Task<User> GetUserById(Func<Guid, bool> func); 
    }
}
