using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;
using PM.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
    public partial class BLL_PEDIDO
    {
        public List<ENT_PEDIDO> SelectAll777(int nCantidad)
        {
            return new DAL_PEDIDO().SelectAll777(nCantidad);
        }
    }
}
