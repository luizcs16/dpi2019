using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MServicio
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_MServicio class.
		/// </summary>
		public ENT_MServicio()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MServicio class.
		/// </summary>
		public ENT_MServicio(int MSRV_nTipoSrv, DateTime MSRV_dHInicio, DateTime MSRV_dHFin, bool MSRV_lActivo, int MSRV_nUsrReg, DateTime MSRV_dFechReg, int MSRV_nUsrMod, DateTime MSRV_dFechMod)
		{
			this.MSRV_nTipoSrv = MSRV_nTipoSrv;
			this.MSRV_dHInicio = MSRV_dHInicio;
			this.MSRV_dHFin = MSRV_dHFin;
			this.MSRV_lActivo = MSRV_lActivo;
			this.MSRV_nUsrReg = MSRV_nUsrReg;
			this.MSRV_dFechReg = MSRV_dFechReg;
			this.MSRV_nUsrMod = MSRV_nUsrMod;
			this.MSRV_dFechMod = MSRV_dFechMod;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MServicio class.
		/// </summary>
		public ENT_MServicio(int MSRV_nId, int MSRV_nTipoSrv, DateTime MSRV_dHInicio, DateTime MSRV_dHFin, bool MSRV_lActivo, int MSRV_nUsrReg, DateTime MSRV_dFechReg, int MSRV_nUsrMod, DateTime MSRV_dFechMod)
		{
			this.MSRV_nId = MSRV_nId;
			this.MSRV_nTipoSrv = MSRV_nTipoSrv;
			this.MSRV_dHInicio = MSRV_dHInicio;
			this.MSRV_dHFin = MSRV_dHFin;
			this.MSRV_lActivo = MSRV_lActivo;
			this.MSRV_nUsrReg = MSRV_nUsrReg;
			this.MSRV_dFechReg = MSRV_dFechReg;
			this.MSRV_nUsrMod = MSRV_nUsrMod;
			this.MSRV_dFechMod = MSRV_dFechMod;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MSRV_nId value. 
		/// </summary>
		public int MSRV_nId { get; set; }

		/// <summary>
		/// Gets or sets the MSRV_nTipoSrv value. 
		/// </summary>
		public int MSRV_nTipoSrv { get; set; }

		/// <summary>
		/// Gets or sets the MSRV_dHInicio value. 
		/// </summary>
		public DateTime MSRV_dHInicio { get; set; }

		/// <summary>
		/// Gets or sets the MSRV_dHFin value. 
		/// </summary>
		public DateTime MSRV_dHFin { get; set; }

		/// <summary>
		/// Gets or sets the MSRV_lActivo value. 
		/// </summary>
		public bool MSRV_lActivo { get; set; }

		/// <summary>
		/// Gets or sets the MSRV_nUsrReg value. 
		/// </summary>
		public int MSRV_nUsrReg { get; set; }

		/// <summary>
		/// Gets or sets the MSRV_dFechReg value. 
		/// </summary>
		public DateTime MSRV_dFechReg { get; set; }

		/// <summary>
		/// Gets or sets the MSRV_nUsrMod value. 
		/// </summary>
		public int MSRV_nUsrMod { get; set; }

		/// <summary>
		/// Gets or sets the MSRV_dFechMod value. 
		/// </summary>
		public DateTime MSRV_dFechMod { get; set; }

		#endregion
	}
}
