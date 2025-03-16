using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implementations
{
    public class UserService : Application.Abstractions.IUserService
    {
        private List<User> users = [new User(), new User(), new User()];

        public void ChangePassword(string password)
        {
            throw new NotImplementedException();
        }

        public void ChangeUsername()
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount()
        {
            throw new NotImplementedException();
        }

        public void Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public void Register(string username, string password)
        {
            throw new NotImplementedException();
        }

        public User GetUser(Predicate<User> filter) 
        {
            return users.Find(filter);
        }
    }
}
