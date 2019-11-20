using Microsoft.ApplicationBlocks.Aptm2019Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptm2019.BusinessLogicLayer
{
    public class BLL_ListJTable
    {
        public List<T> SelectListJTable<T>(string tableName, List<ENT_JTableFilter> filters, int jtStartIndex, int jtPageSize, string jtSorting, out int cantidad)
        {
            return new DAL_ListJTable().SelectListJTable<T>(tableName, filters, jtStartIndex, jtPageSize, jtSorting, out cantidad);
        }
    }
}
