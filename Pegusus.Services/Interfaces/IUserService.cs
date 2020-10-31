using Pegusus.Data.Model;
using System.Threading.Tasks;

namespace Pegusus.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetValidUser(User user);
    }
}
