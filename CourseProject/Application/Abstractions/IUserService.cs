using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IUserService
    {
        void Register(string username, string password);
        void Login(string username, string password);
        void Logout();
        void ChangeUsername();
        void ChangePassword(string password);
        void DeleteAccount();
    }
}
