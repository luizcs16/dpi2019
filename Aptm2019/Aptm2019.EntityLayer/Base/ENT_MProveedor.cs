using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MProveedor
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_MProveedor class.
		/// </summary>
		public ENT_MProveedor()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MProveedor class.
		/// </summary>
		public ENT_MProveedor(int MPROV_nTipoDoc, int MPROV_nDocumento, string MPROV_cNombre, string MPROV_cDireccion, string MPROV_cTelefono, bool MPROV_lActivo, int MPROV_nUsrReg, DateTime MPROV_dFechReg, int MPROV_nUsrMod, DateTime MPROV_dFechMod)
		{
			this.MPROV_nTipoDoc = MPROV_nTipoDoc;
			this.MPROV_nDocumento = MPROV_nDocumento;
			this.MPROV_cNombre = MPROV_cNombre;
			this.MPROV_cDireccion = MPROV_cDireccion;
			this.MPROV_cTelefono = MPROV_cTelefono;
			this.MPROV_lActivo = MPROV_lActivo;
			this.MPROV_nUsrReg = MPROV_nUsrReg;
			this.MPROV_dFechReg = MPROV_dFechReg;
			this.MPROV_nUsrMod = MPROV_nUsrMod;
			this.MPROV_dFechMod = MPROV_dFechMod;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MProveedor class.
		/// </summary>
		public ENT_MProveedor(int MPROV_nId, int MPROV_nTipoDoc, int MPROV_nDocumento, string MPROV_cNombre, string MPROV_cDireccion, string MPROV_cTelefono, bool MPROV_lActivo, int MPROV_nUsrReg, DateTime MPROV_dFechReg, int MPROV_nUsrMod, DateTime MPROV_dFechMod)
		{
			this.MPROV_nId = MPROV_nId;
			this.MPROV_nTipoDoc = MPROV_nTipoDoc;
			this.MPROV_nDocumento = MPROV_nDocumento;
			this.MPROV_cNombre = MPROV_cNombre;
			this.MPROV_cDireccion = MPROV_cDireccion;
			this.MPROV_cTelefono = MPROV_cTelefono;
			this.MPROV_lActivo = MPROV_lActivo;
			this.MPROV_nUsrReg = MPROV_nUsrReg;
			this.MPROV_dFechReg = MPROV_dFechReg;
			this.MPROV_nUsrMod = MPROV_nUsrMod;
			this.MPROV_dFechMod = MPROV_dFechMod;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MPROV_nId value. 
		/// </summary>
		public int MPROV_nId { get; set; }

		/// <summary>
		/// Gets or sets the MPROV_nTipoDoc value. 
		/// </summary>
		public int MPROV_nTipoDoc { get; set; }

		/// <summary>
		/// Gets or sets the MPROV_nDocumento value. 
		/// </summary>
		public int MPROV_nDocumento { get; set; }

		/// <summary>
		/// Gets or sets the MPROV_cNombre value. 
		/// </summary>
		public string MPROV_cNombre { get; set; }

		/// <summary>
		/// Gets or sets the MPROV_cDireccion value. 
		/// </summary>
		public string MPROV_cDireccion { get; set; }

		/// <summary>
		/// Gets or sets the MPROV_cTelefono value. 
		/// </summary>
		public string MPROV_cTelefono { get; set; }

		/// <summary>
		/// Gets or sets the MPROV_lActivo value. 
		/// </summary>
		public bool MPROV_lActivo { get; set; }

		/// <summary>
		/// Gets or sets the MPROV_nUsrReg value. 
		/// </summary>
		public int MPROV_nUsrReg { get; set; }

		/// <summary>
		/// Gets or sets the MPROV_dFechReg value. 
		/// </summary>
		public DateTime MPROV_dFechReg { get; set; }

		/// <summary>
		/// Gets or sets the MPROV_nUsrMod value. 
		/// </summary>
		public int MPROV_nUsrMod { get; set; }

		/// <summary>
		/// Gets or sets the MPROV_dFechMod value. 
		/// </summary>
		public DateTime MPROV_dFechMod { get; set; }

		#endregion
	}
}
