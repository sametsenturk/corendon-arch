using Corendon.Common.Settings.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Data.Entity.Abstract.User
{
    public interface IUserEntity : IBaseEntity
    {
        bool IsLockedAccount();
        bool IsEmployee();
        bool IsManager();
        UserTypeEnum GetUserType();
        int GetId();
    }
}
