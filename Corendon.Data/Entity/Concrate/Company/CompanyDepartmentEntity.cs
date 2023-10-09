﻿using Corendon.Data.Entity.Abstract.Company;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Data.Entity.Concrate.Company
{
    public class CompanyDepartmentEntity : BaseEntity, ICompanyDepartmentEntity
    {
        public string? Name { get; set; }

        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public virtual CompanyEntity? Company { get; set; }
    }
}
