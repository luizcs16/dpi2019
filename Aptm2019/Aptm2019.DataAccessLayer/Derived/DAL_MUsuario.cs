using Aptm2019.EntityLayer;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptm2019.DataAccessLayer
{
    public partial class DAL_MUsuario : DAL_Execute
    {
        public ENT_MUsuario SelectByLogin(string MUSR_cUsuario, string MUSR_cPassword)
        {
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@MUSR_cUsuario", MUSR_cUsuario),
                    new SqlParameter("@MUSR_cPassword", MUSR_cPassword)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            ENT_MUsuario objMUsuario;
            try
            {
                objMUsuario = GetEntity<ENT_MUsuario>("spMUsuario_SelectByLogin", parameters);
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de operación de acceso a datos.", ex);
            }
            return objMUsuario;
        }
    }
}
