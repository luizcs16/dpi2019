using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptm2019.BusinessLogicLayer
{
    public class BLL_ListJTable
    {
        public List<T> SelectListJTable<T>(string tableName, string columnName, string filterValue, int jtStartIndex, int jtPageSize, string jtSorting, bool exact, out int cantidad)
        {
            return new DAL_ListJTable().SelectListJTable<T>(tableName, columnName, filterValue, jtStartIndex, jtPageSize, jtSorting, exact, out cantidad);
        }
    }
}
