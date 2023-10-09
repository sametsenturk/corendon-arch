using Corendon.Data.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Data.Entity.Concrate
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
