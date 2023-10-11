﻿using Corendon.Application.Services.BaseServices;
using Corendon.Data.Entity.Abstract.User;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.Application.Services.User.UserEntityServices
{
    public interface IUserEntityService : ICorendonDbBaseService
    {
        Task<IEnumerable<IUserEntity>> GetUserListAsync();
        Task<IUserEntityVM?> LogInAsync(string username, string password);
    }
}
