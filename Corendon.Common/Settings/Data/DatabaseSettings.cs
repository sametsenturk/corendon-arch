using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Common.Settings.Data
{
    public class DatabaseSettings
    {
        public DatabaseType DatabaseType { get; set; }
        public string? ConnectionString { get; set; }
    }
}
