using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Microsoft.ApplicationBlocks.Aptm2019Data
{
    public class DAL_ListJTable: DAL_Execute
    {
        public static string FormatValue(ENT_JTableFilter filter)
        {
            string begin = filter.SQL_Like ? "'%":"'";
            string end = filter.SQL_Like ? "%'" : "'";
            dynamic value = filter.Value[0];
            if (value is sbyte || value is byte || value is short || value is ushort || value is int || value is uint || value is long || value is ulong || value is float || value is double || value is decimal)
            {
                return Convert.ToString(value);
            }
            else if(value is bool)
            {
                return (bool)value ? "0" : "1";
            }
            else if(value is DateTime)
            {
                return "'"+((DateTime)value).ToString("yyyy-mm-dd hh:mm:ss.nnnnnn")+"'";
            }
            else
            {
                return begin + (filter.SQL_Like? ((string)value).Replace(' ','%'):(string)value) + end;
            }
        }
        public List<T> SelectListJTable<T>(string tableName,List<ENT_JTableFilter> filters, int jtStartIndex, int jtPageSize, string jtSorting, out int cantidad)
        {
            StringBuilder conditions = null;
            if (filters != null)
            {
                conditions = new StringBuilder();
                ENT_JTableFilter filter;
                for (int i = 0; i < filters.Count; i++)
                {
                    filter = filters[i];
                    if (i == 0)
                    {
                        conditions.Append(" WHERE ");
                        if (jtSorting == null && filter.ColumnNames.Length > 0)
                            jtSorting = filter.ColumnNames[0] + " asc";
                    }
                    conditions.Append(string.Join("+", filter.ColumnNames));
                    conditions.Append(filter.SQL_Like ? " LIKE " : " = ");
                    conditions.Append(FormatValue(filter));
                    if (i < filters.Count - 1)
                        conditions.Append(" AND ");
                }
            }
            
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@TABLENAME", tableName),
                    new SqlParameter("@FILTERS", conditions!=null?conditions.ToString():string.Empty),
                    new SqlParameter("@STARTINDEX", jtStartIndex),
                    new SqlParameter("@PAGESIZE", jtPageSize),
                    new SqlParameter("@ORDER", jtSorting),
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
                x_oENT_LSTJTABLE = GetList<T>("spListJTable0", parameters);
                SqlParameter Count = (SqlParameter)parameters.GetValue(5);
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