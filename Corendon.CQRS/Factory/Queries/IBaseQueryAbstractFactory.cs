using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.CQRS.Factory.Queries
{
    public interface IBaseQueryAbstractFactory<TEntity, TValueEntity>
    {
        TEntity Create(IEnumerable<TValueEntity> valueEntities);
        TEntity Create(TValueEntity valueEntity);
    }
}
