using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MCliente
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_MCliente class.
		/// </summary>
		public ENT_MCliente()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MCliente class.
		/// </summary>
		public ENT_MCliente(string MCLI_cNombre, string MCLI_cApePaterno, string MCLI_cApeMaterno, int MCLI_nTipoDoc, string MCLI_cDocumento, bool MCLI_lActivo, int MCLI_nUsrReg, DateTime MCLI_dFechReg, int MCLI_nUsrMod, DateTime MCLI_dFechMod)
		{
			this.MCLI_cNombre = MCLI_cNombre;
			this.MCLI_cApePaterno = MCLI_cApePaterno;
			this.MCLI_cApeMaterno = MCLI_cApeMaterno;
			this.MCLI_nTipoDoc = MCLI_nTipoDoc;
			this.MCLI_cDocumento = MCLI_cDocumento;
			this.MCLI_lActivo = MCLI_lActivo;
			this.MCLI_nUsrReg = MCLI_nUsrReg;
			this.MCLI_dFechReg = MCLI_dFechReg;
			this.MCLI_nUsrMod = MCLI_nUsrMod;
			this.MCLI_dFechMod = MCLI_dFechMod;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MCliente class.
		/// </summary>
		public ENT_MCliente(int MCLI_nId, string MCLI_cNombre, string MCLI_cApePaterno, string MCLI_cApeMaterno, int MCLI_nTipoDoc, string MCLI_cDocumento, bool MCLI_lActivo, int MCLI_nUsrReg, DateTime MCLI_dFechReg, int MCLI_nUsrMod, DateTime MCLI_dFechMod)
		{
			this.MCLI_nId = MCLI_nId;
			this.MCLI_cNombre = MCLI_cNombre;
			this.MCLI_cApePaterno = MCLI_cApePaterno;
			this.MCLI_cApeMaterno = MCLI_cApeMaterno;
			this.MCLI_nTipoDoc = MCLI_nTipoDoc;
			this.MCLI_cDocumento = MCLI_cDocumento;
			this.MCLI_lActivo = MCLI_lActivo;
			this.MCLI_nUsrReg = MCLI_nUsrReg;
			this.MCLI_dFechReg = MCLI_dFechReg;
			this.MCLI_nUsrMod = MCLI_nUsrMod;
			this.MCLI_dFechMod = MCLI_dFechMod;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MCLI_nId value. 
		/// </summary>
		public int MCLI_nId { get; set; }

		/// <summary>
		/// Gets or sets the MCLI_cNombre value. 
		/// </summary>
		public string MCLI_cNombre { get; set; }

		/// <summary>
		/// Gets or sets the MCLI_cApePaterno value. 
		/// </summary>
		public string MCLI_cApePaterno { get; set; }

		/// <summary>
		/// Gets or sets the MCLI_cApeMaterno value. 
		/// </summary>
		public string MCLI_cApeMaterno { get; set; }

		/// <summary>
		/// Gets or sets the MCLI_nTipoDoc value. 
		/// </summary>
		public int MCLI_nTipoDoc { get; set; }

		/// <summary>
		/// Gets or sets the MCLI_cDocumento value. 
		/// </summary>
		public string MCLI_cDocumento { get; set; }

		/// <summary>
		/// Gets or sets the MCLI_lActivo value. 
		/// </summary>
		public bool MCLI_lActivo { get; set; }

		/// <summary>
		/// Gets or sets the MCLI_nUsrReg value. 
		/// </summary>
		public int MCLI_nUsrReg { get; set; }

		/// <summary>
		/// Gets or sets the MCLI_dFechReg value. 
		/// </summary>
		public DateTime MCLI_dFechReg { get; set; }

		/// <summary>
		/// Gets or sets the MCLI_nUsrMod value. 
		/// </summary>
		public int MCLI_nUsrMod { get; set; }

		/// <summary>
		/// Gets or sets the MCLI_dFechMod value. 
		/// </summary>
		public DateTime MCLI_dFechMod { get; set; }

		#endregion
	}
}
