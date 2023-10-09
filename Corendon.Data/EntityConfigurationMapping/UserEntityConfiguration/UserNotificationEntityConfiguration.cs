using Corendon.Data.Entity.Concrate.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Corendon.Data.EntityConfigurationMapping.UserEntityConfiguration
{
    public class UserNotificationEntityConfiguration : IEntityTypeConfiguration<UserNotificationEntity>
    {
        public void Configure(EntityTypeBuilder<UserNotificationEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired();
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.AnnouncementId).IsRequired();

            builder.HasIndex(x => x.UserId);
        }
    }
}
