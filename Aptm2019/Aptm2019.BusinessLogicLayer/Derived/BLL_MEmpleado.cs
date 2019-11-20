using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;
using Microsoft.ApplicationBlocks.Aptm2019Data;

namespace Aptm2019.BusinessLogicLayer
{
	public partial class BLL_MEmpleado
	{
        public List<ENT_MEmpleado> SelectListJTable(List<ENT_JTableFilter> filters, int jtStartIndex, int jtPageSize, string jtSorting, out int cantidad)
        {
            return new BLL_ListJTable().SelectListJTable<ENT_MEmpleado>("MEmpleado", filters, jtStartIndex, jtPageSize, jtSorting, out cantidad);
        }
    }
}
