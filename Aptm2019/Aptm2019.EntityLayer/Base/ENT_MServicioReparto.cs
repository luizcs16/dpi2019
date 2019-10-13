using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MServicioReparto
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_MServicioReparto class.
		/// </summary>
		public ENT_MServicioReparto()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MServicioReparto class.
		/// </summary>
		public ENT_MServicioReparto(int MSVRP_nIdMServicio, int MSVRP_nIdMVehiculo, bool MSVRP_lActivo, int MSVRP_nUsrReg, DateTime MSVRP_dFechReg, int MSVRP_nUsrMod, DateTime MSVRP_dFechMod)
		{
			this.MSVRP_nIdMServicio = MSVRP_nIdMServicio;
			this.MSVRP_nIdMVehiculo = MSVRP_nIdMVehiculo;
			this.MSVRP_lActivo = MSVRP_lActivo;
			this.MSVRP_nUsrReg = MSVRP_nUsrReg;
			this.MSVRP_dFechReg = MSVRP_dFechReg;
			this.MSVRP_nUsrMod = MSVRP_nUsrMod;
			this.MSVRP_dFechMod = MSVRP_dFechMod;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MServicioReparto class.
		/// </summary>
		public ENT_MServicioReparto(int MSVRP_nId, int MSVRP_nIdMServicio, int MSVRP_nIdMVehiculo, bool MSVRP_lActivo, int MSVRP_nUsrReg, DateTime MSVRP_dFechReg, int MSVRP_nUsrMod, DateTime MSVRP_dFechMod)
		{
			this.MSVRP_nId = MSVRP_nId;
			this.MSVRP_nIdMServicio = MSVRP_nIdMServicio;
			this.MSVRP_nIdMVehiculo = MSVRP_nIdMVehiculo;
			this.MSVRP_lActivo = MSVRP_lActivo;
			this.MSVRP_nUsrReg = MSVRP_nUsrReg;
			this.MSVRP_dFechReg = MSVRP_dFechReg;
			this.MSVRP_nUsrMod = MSVRP_nUsrMod;
			this.MSVRP_dFechMod = MSVRP_dFechMod;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MSVRP_nId value. 
		/// </summary>
		public int MSVRP_nId { get; set; }

		/// <summary>
		/// Gets or sets the MSVRP_nIdMServicio value. 
		/// </summary>
		public int MSVRP_nIdMServicio { get; set; }

		/// <summary>
		/// Gets or sets the MSVRP_nIdMVehiculo value. 
		/// </summary>
		public int MSVRP_nIdMVehiculo { get; set; }

		/// <summary>
		/// Gets or sets the MSVRP_lActivo value. 
		/// </summary>
		public bool MSVRP_lActivo { get; set; }

		/// <summary>
		/// Gets or sets the MSVRP_nUsrReg value. 
		/// </summary>
		public int MSVRP_nUsrReg { get; set; }

		/// <summary>
		/// Gets or sets the MSVRP_dFechReg value. 
		/// </summary>
		public DateTime MSVRP_dFechReg { get; set; }

		/// <summary>
		/// Gets or sets the MSVRP_nUsrMod value. 
		/// </summary>
		public int MSVRP_nUsrMod { get; set; }

		/// <summary>
		/// Gets or sets the MSVRP_dFechMod value. 
		/// </summary>
		public DateTime MSVRP_dFechMod { get; set; }

		#endregion
	}
}
