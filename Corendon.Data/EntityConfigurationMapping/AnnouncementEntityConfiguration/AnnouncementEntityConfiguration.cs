using Corendon.Data.Entity.Concrate.Announcement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Data.EntityConfigurationMapping.AnnouncementEntityConfiguration
{
    public class AnnouncementEntityConfiguration : IEntityTypeConfiguration<AnnouncementEntity>
    {
        public void Configure(EntityTypeBuilder<AnnouncementEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired();
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.AnnouncementType).IsRequired();
            builder.Property(x => x.CreatedUserId).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(512).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(25).IsRequired();
            builder.Property(x => x.PicturePath).HasMaxLength(512).IsRequired();
        }
    }
}
