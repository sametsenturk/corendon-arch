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
    public class UserAnnouncementVoteEntityConfiguration : IEntityTypeConfiguration<UserAnnouncementVoteEntity>
    {
        public void Configure(EntityTypeBuilder<UserAnnouncementVoteEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired();
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.VoteType).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.AnnouncementId).IsRequired();

            builder.HasIndex(x => x.AnnouncementId);
        }
    }
}
