using Corendon.Data.Entity.Concrate.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Corendon.Data.EntityConfigurationMapping.UserEntityConfiguration
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired();
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.UserType).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(35).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(35).IsRequired();
            builder.Property(x => x.IsLocked).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(55).IsRequired();
            builder.Property(x => x.Username).HasMaxLength(25).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(25).IsRequired();
            builder.Property(x => x.PicturePath).HasMaxLength(255).IsRequired();

            builder.HasIndex(x => x.Username);
            builder.HasIndex(x => x.Email);
        }
    }
}
