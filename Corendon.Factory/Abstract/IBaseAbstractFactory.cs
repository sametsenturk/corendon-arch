using Corendon.Data.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Factory.Abstract
{
    public interface IBaseAbstractFactory<TEntity>
    {
        TEntity Create();
    }
}
