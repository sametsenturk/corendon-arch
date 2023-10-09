using Corendon.Data.Context;
using Corendon.Data.Entity.Concrate.Announcement;
using Corendon.Data.Entity.Concrate.Company;
using Corendon.Data.Entity.Concrate.User;
using Corendon.Data.EntityConfigurationMapping;
using Corendon.Data.EntityConfigurationMapping.AnnouncementEntityConfiguration;
using Corendon.Data.EntityConfigurationMapping.CompanyEntityConfiguration;
using Corendon.Data.EntityConfigurationMapping.UserEntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Corendon.Entity.Context
{
    public class CorendonDbContext : DbContextBase
    {
        public CorendonDbContext([NotNull] DbContextOptions<CorendonDbContext> options) : base(options)
        {
        }

        public CorendonDbContext()
        {
        }

        #region Announcement

        public DbSet<AnnouncementEntity> Announcements { get; set; }

        #endregion

        #region Company

        public DbSet<CompanyEntity> Companies { get; set; }
        public DbSet<CompanyDepartmentEntity> CompanyDepartments { get; set; }

        #endregion

        #region User

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<UserNotificationEntity> UserNotifications { get; set; }
        public DbSet<UserAnnouncementVoteEntity> UserAnnouncementVotes { get; set; }
        public DbSet<UserAnnouncementCommentEntity> UserAnnouncementComments { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new BaseEntityConfiguration());

            #region Announcement Configuration

            modelBuilder.ApplyConfiguration(new AnnouncementEntityConfiguration());

            #endregion

            #region Company Configuration

            modelBuilder.ApplyConfiguration(new CompanyEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyDepartmentEntityConfiguration());

            #endregion

            #region User Configuration

            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserNotificationEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserAnnouncementVoteEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserAnnouncementCommentEntityConfiguration());

            #endregion
        }

    }
}
