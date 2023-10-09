using Corendon.Data.Entity.Concrate.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Data.EntityConfigurationMapping.UserEntityConfiguration
{
    public class UserAnnouncementCommentEntityConfiguration : IEntityTypeConfiguration<UserAnnouncementCommentEntity>
    {
        public void Configure(EntityTypeBuilder<UserAnnouncementCommentEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired();
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.IsApproved).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.AnnouncementId).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(255).IsRequired();

            builder.HasIndex(x => x.UserId);
            builder.HasIndex(x => x.AnnouncementId);
        }
    }
}
