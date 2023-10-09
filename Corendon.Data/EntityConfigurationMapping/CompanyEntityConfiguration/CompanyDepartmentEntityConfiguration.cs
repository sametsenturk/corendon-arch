using Corendon.Data.Entity.Concrate.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Data.EntityConfigurationMapping.CompanyEntityConfiguration
{
    public class CompanyDepartmentEntityConfiguration : IEntityTypeConfiguration<CompanyDepartmentEntity>
    {
        public void Configure(EntityTypeBuilder<CompanyDepartmentEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired();
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.CompanyId).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();

            builder.HasIndex(x => x.CompanyId);
        }
    }
}
