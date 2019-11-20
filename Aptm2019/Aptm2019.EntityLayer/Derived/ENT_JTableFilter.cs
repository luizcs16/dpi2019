using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ApplicationBlocks.Aptm2019Data
{
    public class ENT_JTableFilter
    {
        public string[] ColumnNames { get; set; }
        public dynamic[] Value { get; set; }
        public bool SQL_Like { get; set; }
    }
}
