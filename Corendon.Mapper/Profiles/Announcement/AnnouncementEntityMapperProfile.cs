using AutoMapper;
using Corendon.Data.Entity.Abstract.Announcement;

namespace Corendon.Mapper.Profiles.Announcement
{
    public class AnnouncementEntityMapperProfile : Profile
    {
        public AnnouncementEntityMapperProfile()
        {
            CreateMap<IAnnouncementEntity, IAnnouncementEntity>();
        }
    }
}
