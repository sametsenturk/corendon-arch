using Corendon.Data.Entity.Abstract.User;

namespace Corendon.Security.Abstract
{
    public interface IJsonWebTokenHelper
    {
        string GenerateJsonWebToken(IUserEntity user);
    }
}
