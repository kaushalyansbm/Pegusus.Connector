using Pegusus.Data.Model;
using Pegusus.Data.Repository;
using Pegusus.Services.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace Pegusus.Services.Infrastructures
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<User> _userRepository;
        public UserService(IBaseRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> GetValidUser(User user)
        {
            return  _userRepository.getAllAsync().Result.Where(detail=>detail.Email==user.Email).ToList().FirstOrDefault();
        }
    }
}
