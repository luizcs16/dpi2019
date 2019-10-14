using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptm2019.BusinessLogicLayer
{
    public partial class BLL_MUsuario
    {
        public ENT_MUsuario SelectByLogin(string MUSR_cUsuario, string MUSR_cPassword)
        {
            return new DAL_MUsuario().SelectByLogin(MUSR_cUsuario, MUSR_cPassword);
        }
    }
}
