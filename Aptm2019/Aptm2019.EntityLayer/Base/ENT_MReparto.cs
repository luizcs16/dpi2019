using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MReparto
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_MReparto class.
		/// </summary>
		public ENT_MReparto()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MReparto class.
		/// </summary>
		public ENT_MReparto(int MRPT_nIdServicioReparto, DateTime MRPT_dHInicio, DateTime MRPT_dHFin, bool MRPT_lActivo, int MRPT_nUsrReg, DateTime MRPT_dFechReg, int MRPT_nUsrMod, DateTime MRPT_dFechMod)
		{
			this.MRPT_nIdServicioReparto = MRPT_nIdServicioReparto;
			this.MRPT_dHInicio = MRPT_dHInicio;
			this.MRPT_dHFin = MRPT_dHFin;
			this.MRPT_lActivo = MRPT_lActivo;
			this.MRPT_nUsrReg = MRPT_nUsrReg;
			this.MRPT_dFechReg = MRPT_dFechReg;
			this.MRPT_nUsrMod = MRPT_nUsrMod;
			this.MRPT_dFechMod = MRPT_dFechMod;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MReparto class.
		/// </summary>
		public ENT_MReparto(int MRPT_nId, int MRPT_nIdServicioReparto, DateTime MRPT_dHInicio, DateTime MRPT_dHFin, bool MRPT_lActivo, int MRPT_nUsrReg, DateTime MRPT_dFechReg, int MRPT_nUsrMod, DateTime MRPT_dFechMod)
		{
			this.MRPT_nId = MRPT_nId;
			this.MRPT_nIdServicioReparto = MRPT_nIdServicioReparto;
			this.MRPT_dHInicio = MRPT_dHInicio;
			this.MRPT_dHFin = MRPT_dHFin;
			this.MRPT_lActivo = MRPT_lActivo;
			this.MRPT_nUsrReg = MRPT_nUsrReg;
			this.MRPT_dFechReg = MRPT_dFechReg;
			this.MRPT_nUsrMod = MRPT_nUsrMod;
			this.MRPT_dFechMod = MRPT_dFechMod;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MRPT_nId value. 
		/// </summary>
		public int MRPT_nId { get; set; }

		/// <summary>
		/// Gets or sets the MRPT_nIdServicioReparto value. 
		/// </summary>
		public int MRPT_nIdServicioReparto { get; set; }

		/// <summary>
		/// Gets or sets the MRPT_dHInicio value. 
		/// </summary>
		public DateTime MRPT_dHInicio { get; set; }

		/// <summary>
		/// Gets or sets the MRPT_dHFin value. 
		/// </summary>
		public DateTime MRPT_dHFin { get; set; }

		/// <summary>
		/// Gets or sets the MRPT_lActivo value. 
		/// </summary>
		public bool MRPT_lActivo { get; set; }

		/// <summary>
		/// Gets or sets the MRPT_nUsrReg value. 
		/// </summary>
		public int MRPT_nUsrReg { get; set; }

		/// <summary>
		/// Gets or sets the MRPT_dFechReg value. 
		/// </summary>
		public DateTime MRPT_dFechReg { get; set; }

		/// <summary>
		/// Gets or sets the MRPT_nUsrMod value. 
		/// </summary>
		public int MRPT_nUsrMod { get; set; }

		/// <summary>
		/// Gets or sets the MRPT_dFechMod value. 
		/// </summary>
		public DateTime MRPT_dFechMod { get; set; }

		#endregion
	}
}
