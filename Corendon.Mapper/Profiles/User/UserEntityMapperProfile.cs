using AutoMapper;
using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Response;
using Corendon.Data.Entity.Abstract.User;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.Mapper.Profiles.User
{
    public class UserEntityMapperProfile : Profile
    {
        public UserEntityMapperProfile()
        {
            CreateMap<IUserEntityModel, IUserEntity>().ReverseMap();
        }
    }
}
