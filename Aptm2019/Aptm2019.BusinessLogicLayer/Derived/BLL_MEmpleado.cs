using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public partial class BLL_MEmpleado
	{
        public List<ENT_MEmpleado> SelectListJTable(string columnName, string filterValue, int jtStartIndex, int jtPageSize, string jtSorting,bool exact, out int cantidad)
        {
            return new BLL_ListJTable().SelectListJTable< ENT_MEmpleado>("MEmpleado", columnName, filterValue, jtStartIndex, jtPageSize, jtSorting, exact, out cantidad);
        }
    }
}
