using Corendon.Data.UnitOfWork.Abstract;
using Corendon.Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Repository.UnitOfWork.Abstract
{
    public interface ICorendonDbUnitOfWork : IUnitOfWork<CorendonDbContext>
    {
    }
}
