using Corendon.Data.Entity.Abstract.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Data.Entity.Concrate.Company
{
    public class CompanyEntity : BaseEntity, ICompanyEntity
    {
        public string? Name { get; set; }

        public virtual List<CompanyDepartmentEntity>? CompanyDepartments { get; set; }
    }
}
