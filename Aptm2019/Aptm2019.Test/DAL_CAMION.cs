using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Aptm2019.EntityLayer;
using Microsoft.ApplicationBlocks.Data;

namespace Aptm2019.DataAccessLayer
{
    public partial class DAL_CAMION : DAL_Execute
    {
        public List<ENT_CAMION> SelectAll777(int nCantidad)
        {
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@cant", nCantidad)
                };
                List<ENT_CAMION> x_oENT_BS_VEHICULO_CONDUCTORList = new List<ENT_CAMION>();
                x_oENT_BS_VEHICULO_CONDUCTORList = GetList<ENT_CAMION>("spBS_VEHICULO_CONDUCTORSelectAll777", parameters);
                return x_oENT_BS_VEHICULO_CONDUCTORList;
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }
        }
    }
}
