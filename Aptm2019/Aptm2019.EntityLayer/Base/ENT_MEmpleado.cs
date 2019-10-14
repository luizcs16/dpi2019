using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MEmpleado
	{
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the ENT_MEmpleado class.
        /// </summary>
        public ENT_MEmpleado()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ENT_MEmpleado class.
        /// </summary>
        public ENT_MEmpleado(string MEMP_cNombre, string MEMP_cApePaterno, string MEMP_cApeMaterno, int MEMP_nTipoDoc, int MEMP_nDocumento, string MEMP_cDireccion, string MEMP_cTelefono, bool MEMP_lActivo, int MEMP_nUsrReg, DateTime MEMP_dFechReg, int MEMP_nUsrMod, DateTime MEMP_dFechMod)
        {
            this.MEMP_cNombre = MEMP_cNombre;
            this.MEMP_cApePaterno = MEMP_cApePaterno;
            this.MEMP_cApeMaterno = MEMP_cApeMaterno;
            this.MEMP_nTipoDoc = MEMP_nTipoDoc;
            this.MEMP_nDocumento = MEMP_nDocumento;
            this.MEMP_cDireccion = MEMP_cDireccion;
            this.MEMP_cTelefono = MEMP_cTelefono;
            this.MEMP_lActivo = MEMP_lActivo;
            this.MEMP_nUsrReg = MEMP_nUsrReg;
            this.MEMP_dFechReg = MEMP_dFechReg;
            this.MEMP_nUsrMod = MEMP_nUsrMod;
            this.MEMP_dFechMod = MEMP_dFechMod;
        }

        /// <summary>
        /// Initializes a new instance of the ENT_MEmpleado class.
        /// </summary>
        public ENT_MEmpleado(int MEMP_nId, string MEMP_cNombre, string MEMP_cApePaterno, string MEMP_cApeMaterno, int MEMP_nTipoDoc, int MEMP_nDocumento, string MEMP_cDireccion, string MEMP_cTelefono, bool MEMP_lActivo, int MEMP_nUsrReg, DateTime MEMP_dFechReg, int MEMP_nUsrMod, DateTime MEMP_dFechMod)
        {
            this.MEMP_nId = MEMP_nId;
            this.MEMP_cNombre = MEMP_cNombre;
            this.MEMP_cApePaterno = MEMP_cApePaterno;
            this.MEMP_cApeMaterno = MEMP_cApeMaterno;
            this.MEMP_nTipoDoc = MEMP_nTipoDoc;
            this.MEMP_nDocumento = MEMP_nDocumento;
            this.MEMP_cDireccion = MEMP_cDireccion;
            this.MEMP_cTelefono = MEMP_cTelefono;
            this.MEMP_lActivo = MEMP_lActivo;
            this.MEMP_nUsrReg = MEMP_nUsrReg;
            this.MEMP_dFechReg = MEMP_dFechReg;
            this.MEMP_nUsrMod = MEMP_nUsrMod;
            this.MEMP_dFechMod = MEMP_dFechMod;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the MEMP_nId value. 
        /// </summary>
        public int MEMP_nId { get; set; }

        /// <summary>
        /// Gets or sets the MEMP_cNombre value. 
        /// </summary>
        public string MEMP_cNombre { get; set; }

        /// <summary>
        /// Gets or sets the MEMP_cApePaterno value. 
        /// </summary>
        public string MEMP_cApePaterno { get; set; }

        /// <summary>
        /// Gets or sets the MEMP_cApeMaterno value. 
        /// </summary>
        public string MEMP_cApeMaterno { get; set; }

        /// <summary>
        /// Gets or sets the MEMP_nTipoDoc value. 
        /// </summary>
        public int MEMP_nTipoDoc { get; set; }

        /// <summary>
        /// Gets or sets the MEMP_nDocumento value. 
        /// </summary>
        public int MEMP_nDocumento { get; set; }

        /// <summary>
        /// Gets or sets the MEMP_cDireccion value. 
        /// </summary>
        public string MEMP_cDireccion { get; set; }

        /// <summary>
        /// Gets or sets the MEMP_cTelefono value. 
        /// </summary>
        public string MEMP_cTelefono { get; set; }

        /// <summary>
        /// Gets or sets the MEMP_lActivo value. 
        /// </summary>
        public bool MEMP_lActivo { get; set; }

        /// <summary>
        /// Gets or sets the MEMP_nUsrReg value. 
        /// </summary>
        public int MEMP_nUsrReg { get; set; }

        /// <summary>
        /// Gets or sets the MEMP_dFechReg value. 
        /// </summary>
        public DateTime MEMP_dFechReg { get; set; }

        /// <summary>
        /// Gets or sets the MEMP_nUsrMod value. 
        /// </summary>
        public int MEMP_nUsrMod { get; set; }

        /// <summary>
        /// Gets or sets the MEMP_dFechMod value. 
        /// </summary>
        public DateTime MEMP_dFechMod { get; set; }

        #endregion
    }
}
