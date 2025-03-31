using Core.Models;

namespace Infrastructure.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(JsonService jsonService) : base(jsonService)
        {
        }
    }
}
