using Corendon.Data.Entity.Abstract.Company;
using Corendon.Data.Entity.Concrate.Company;
using Corendon.Factory.Abstract.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Factory.Concrate.Company
{
    public class CompanyFactory : ICompanyAbstractFactory
    {
        public ICompanyEntity Create() => new CompanyEntity();
    }
}
