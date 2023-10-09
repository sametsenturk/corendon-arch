using AutoMapper;
using Corendon.CQRS.Queries.Abstract.User.UserEntity.Queries.Response;
using Corendon.Data.Entity.Abstract.User;

namespace Corendon.Mapper.Profiles.User
{
    public class UserEntityMapperProfile : Profile
    {
        public UserEntityMapperProfile()
        {
            CreateMap<IGetAllUserQueryResponse, IUserEntity>().ReverseMap();
        }
    }
}
