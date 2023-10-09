using Corendon.Data.Context;
using Corendon.Data.Entity.Concrate.Company;
using Corendon.Data.Repository.Abstract;
using Corendon.Data.Repository.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Repository.Repositories.Company.CompanyEntityRepositories
{
    public class CompanyEntityRepository : EntityRepository<CompanyEntity>, ICompanyEntityRepository
    {
        public CompanyEntityRepository(DbContextBase dbContext) : base(dbContext)
        {
        }
    }
}
