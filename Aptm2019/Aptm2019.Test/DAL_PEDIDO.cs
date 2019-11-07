using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Aptm2019.EntityLayer;
using Microsoft.ApplicationBlocks.Data;

namespace Aptm2019.DataAccessLayer
{
    public partial class DAL_PEDIDO : DAL_Execute
    {
        public List<ENT_PEDIDO> SelectAll777(int nCantidad)
        {
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@cant", nCantidad)
                };
                List<ENT_PEDIDO> x_oENT_BS_SERVICIO_DETALLEList = new List<ENT_PEDIDO>();
                x_oENT_BS_SERVICIO_DETALLEList = GetList<ENT_PEDIDO>("spBS_SERVICIO_DETALLESelectAll777",parameters);
                return x_oENT_BS_SERVICIO_DETALLEList;
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }
        }
    }
}
