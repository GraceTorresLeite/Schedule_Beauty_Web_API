using WebServiceApi.Data.VO;
using WebServiceApi.Models;

namespace WebServiceApi.Repository
{
    public interface IUserRepository
    {
        User ValidateCredenctials(UserVO user);

        User ValidateCredenctials(string username);

        bool RevokeToken(string username);

        User RefreshUserInfo(User user);
    }
}
