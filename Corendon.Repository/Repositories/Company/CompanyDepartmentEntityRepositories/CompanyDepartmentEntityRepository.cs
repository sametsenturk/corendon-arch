using Corendon.Data.Context;
using Corendon.Data.Entity.Concrate.Company;
using Corendon.Data.Repository.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Repository.Repositories.Company.CompanyDepartmentEntityRepositories
{
    public class CompanyDepartmentEntityRepository : EntityRepository<CompanyDepartmentEntity>, ICompanyDepartmentEntityRepository
    {
        public CompanyDepartmentEntityRepository(DbContextBase dbContext) : base(dbContext)
        {
        }
    }
}
