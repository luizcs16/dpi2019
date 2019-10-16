using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Microsoft.ApplicationBlocks.Data
{
    public class DAL_ListJTable: DAL_Execute
    {
        public List<T> SelectListJTable<T>(string tableName,string columnName, string filterValue, int jtStartIndex, int jtPageSize, string jtSorting, bool exact, out int cantidad)
        {
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@TABLENAME", tableName),
                    new SqlParameter("@COLUMNAME", columnName),
                    new SqlParameter("@FILTERVALUE", filterValue),
                    new SqlParameter("@STARTINDEX", jtStartIndex),
                    new SqlParameter("@PAGESIZE", jtPageSize),
                    new SqlParameter("@ORDER", jtSorting),
                    new SqlParameter("@EXACT", exact),
                    new SqlParameter("@COUNT", SqlDbType.Int){Direction = ParameterDirection.Output}
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            List<T> x_oENT_LSTJTABLE = new List<T>();

            try
            {
                x_oENT_LSTJTABLE = GetList<T>("spListJTable", parameters);
                var Count = (SqlParameter)parameters.GetValue(7);
                cantidad = Convert.ToInt32(Count.Value);

            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }
            return x_oENT_LSTJTABLE;
        }
    }
}