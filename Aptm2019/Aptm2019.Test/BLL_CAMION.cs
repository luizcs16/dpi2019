using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;
using PM.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
    public partial class BLL_CAMION
    {
        public List<ENT_CAMION> SelectAll777(int nCantidad)
        {
            return new DAL_CAMION().SelectAll777(nCantidad);
        }
    }
}
