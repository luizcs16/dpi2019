using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MRepartoItem
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_MRepartoItem class.
		/// </summary>
		public ENT_MRepartoItem()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MRepartoItem class.
		/// </summary>
		public ENT_MRepartoItem(int MRPITM_nTipoComprobante, string MRPITM_cComprobante, int MRPITM_nIdCliente, decimal MRPITM_nLat, decimal MRPITM_nLong, string MRPITM_cDireccion, decimal MRPITM_nAncho, decimal MRPITM_nLargo, decimal MRPITM_nAlto, int MRPITM_nEstado, bool MRPITM_lActivo, int MRPITM_nUsrReg, DateTime MRPITM_dFechReg, int MRPITM_nUsrMod, DateTime MRPITM_dFechMod)
		{
			this.MRPITM_nTipoComprobante = MRPITM_nTipoComprobante;
			this.MRPITM_cComprobante = MRPITM_cComprobante;
			this.MRPITM_nIdCliente = MRPITM_nIdCliente;
			this.MRPITM_nLat = MRPITM_nLat;
			this.MRPITM_nLong = MRPITM_nLong;
			this.MRPITM_cDireccion = MRPITM_cDireccion;
			this.MRPITM_nAncho = MRPITM_nAncho;
			this.MRPITM_nLargo = MRPITM_nLargo;
			this.MRPITM_nAlto = MRPITM_nAlto;
			this.MRPITM_nEstado = MRPITM_nEstado;
			this.MRPITM_lActivo = MRPITM_lActivo;
			this.MRPITM_nUsrReg = MRPITM_nUsrReg;
			this.MRPITM_dFechReg = MRPITM_dFechReg;
			this.MRPITM_nUsrMod = MRPITM_nUsrMod;
			this.MRPITM_dFechMod = MRPITM_dFechMod;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MRepartoItem class.
		/// </summary>
		public ENT_MRepartoItem(int MRPITM_nId, int MRPITM_nTipoComprobante, string MRPITM_cComprobante, int MRPITM_nIdCliente, decimal MRPITM_nLat, decimal MRPITM_nLong, string MRPITM_cDireccion, decimal MRPITM_nAncho, decimal MRPITM_nLargo, decimal MRPITM_nAlto, int MRPITM_nEstado, bool MRPITM_lActivo, int MRPITM_nUsrReg, DateTime MRPITM_dFechReg, int MRPITM_nUsrMod, DateTime MRPITM_dFechMod)
		{
			this.MRPITM_nId = MRPITM_nId;
			this.MRPITM_nTipoComprobante = MRPITM_nTipoComprobante;
			this.MRPITM_cComprobante = MRPITM_cComprobante;
			this.MRPITM_nIdCliente = MRPITM_nIdCliente;
			this.MRPITM_nLat = MRPITM_nLat;
			this.MRPITM_nLong = MRPITM_nLong;
			this.MRPITM_cDireccion = MRPITM_cDireccion;
			this.MRPITM_nAncho = MRPITM_nAncho;
			this.MRPITM_nLargo = MRPITM_nLargo;
			this.MRPITM_nAlto = MRPITM_nAlto;
			this.MRPITM_nEstado = MRPITM_nEstado;
			this.MRPITM_lActivo = MRPITM_lActivo;
			this.MRPITM_nUsrReg = MRPITM_nUsrReg;
			this.MRPITM_dFechReg = MRPITM_dFechReg;
			this.MRPITM_nUsrMod = MRPITM_nUsrMod;
			this.MRPITM_dFechMod = MRPITM_dFechMod;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MRPITM_nId value. 
		/// </summary>
		public int MRPITM_nId { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_nTipoComprobante value. 
		/// </summary>
		public int MRPITM_nTipoComprobante { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_cComprobante value. 
		/// </summary>
		public string MRPITM_cComprobante { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_nIdCliente value. 
		/// </summary>
		public int MRPITM_nIdCliente { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_nLat value. 
		/// </summary>
		public decimal MRPITM_nLat { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_nLong value. 
		/// </summary>
		public decimal MRPITM_nLong { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_cDireccion value. 
		/// </summary>
		public string MRPITM_cDireccion { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_nAncho value. 
		/// </summary>
		public decimal MRPITM_nAncho { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_nLargo value. 
		/// </summary>
		public decimal MRPITM_nLargo { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_nAlto value. 
		/// </summary>
		public decimal MRPITM_nAlto { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_nEstado value. 
		/// </summary>
		public int MRPITM_nEstado { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_lActivo value. 
		/// </summary>
		public bool MRPITM_lActivo { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_nUsrReg value. 
		/// </summary>
		public int MRPITM_nUsrReg { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_dFechReg value. 
		/// </summary>
		public DateTime MRPITM_dFechReg { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_nUsrMod value. 
		/// </summary>
		public int MRPITM_nUsrMod { get; set; }

		/// <summary>
		/// Gets or sets the MRPITM_dFechMod value. 
		/// </summary>
		public DateTime MRPITM_dFechMod { get; set; }

		#endregion
	}
}
