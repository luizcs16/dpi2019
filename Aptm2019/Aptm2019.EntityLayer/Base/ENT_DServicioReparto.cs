using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_DServicioReparto
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_DServicioReparto class.
		/// </summary>
		public ENT_DServicioReparto()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_DServicioReparto class.
		/// </summary>
		public ENT_DServicioReparto(int DSVRP_nIdMServicioReparto, int DSVRP_nIdMEmpleado, bool DSVRP_lActivo, int DSVRP_nUsrReg, DateTime DSVRP_dFechReg, int DSVRP_nUsrMod, DateTime DSVRP_dFechMod)
		{
			this.DSVRP_nIdMServicioReparto = DSVRP_nIdMServicioReparto;
			this.DSVRP_nIdMEmpleado = DSVRP_nIdMEmpleado;
			this.DSVRP_lActivo = DSVRP_lActivo;
			this.DSVRP_nUsrReg = DSVRP_nUsrReg;
			this.DSVRP_dFechReg = DSVRP_dFechReg;
			this.DSVRP_nUsrMod = DSVRP_nUsrMod;
			this.DSVRP_dFechMod = DSVRP_dFechMod;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_DServicioReparto class.
		/// </summary>
		public ENT_DServicioReparto(int DSVRP_nId, int DSVRP_nIdMServicioReparto, int DSVRP_nIdMEmpleado, bool DSVRP_lActivo, int DSVRP_nUsrReg, DateTime DSVRP_dFechReg, int DSVRP_nUsrMod, DateTime DSVRP_dFechMod)
		{
			this.DSVRP_nId = DSVRP_nId;
			this.DSVRP_nIdMServicioReparto = DSVRP_nIdMServicioReparto;
			this.DSVRP_nIdMEmpleado = DSVRP_nIdMEmpleado;
			this.DSVRP_lActivo = DSVRP_lActivo;
			this.DSVRP_nUsrReg = DSVRP_nUsrReg;
			this.DSVRP_dFechReg = DSVRP_dFechReg;
			this.DSVRP_nUsrMod = DSVRP_nUsrMod;
			this.DSVRP_dFechMod = DSVRP_dFechMod;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DSVRP_nId value. 
		/// </summary>
		public int DSVRP_nId { get; set; }

		/// <summary>
		/// Gets or sets the DSVRP_nIdMServicioReparto value. 
		/// </summary>
		public int DSVRP_nIdMServicioReparto { get; set; }

		/// <summary>
		/// Gets or sets the DSVRP_nIdMEmpleado value. 
		/// </summary>
		public int DSVRP_nIdMEmpleado { get; set; }

		/// <summary>
		/// Gets or sets the DSVRP_lActivo value. 
		/// </summary>
		public bool DSVRP_lActivo { get; set; }

		/// <summary>
		/// Gets or sets the DSVRP_nUsrReg value. 
		/// </summary>
		public int DSVRP_nUsrReg { get; set; }

		/// <summary>
		/// Gets or sets the DSVRP_dFechReg value. 
		/// </summary>
		public DateTime DSVRP_dFechReg { get; set; }

		/// <summary>
		/// Gets or sets the DSVRP_nUsrMod value. 
		/// </summary>
		public int DSVRP_nUsrMod { get; set; }

		/// <summary>
		/// Gets or sets the DSVRP_dFechMod value. 
		/// </summary>
		public DateTime DSVRP_dFechMod { get; set; }

		#endregion
	}
}
