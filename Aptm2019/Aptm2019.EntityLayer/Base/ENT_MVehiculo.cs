using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MVehiculo
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_MVehiculo class.
		/// </summary>
		public ENT_MVehiculo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MVehiculo class.
		/// </summary>
		public ENT_MVehiculo(string MVEH_cPlaca, string MVEH_cTPropiedad, int MVEH_nIdMProveedor, int MVEH_nIdMModelo, bool MVEH_lActivo, int MVEH_nUsrReg, DateTime MVEH_dFechReg, int MVEH_nUsrMod, DateTime MVEH_dFechMod)
		{
			this.MVEH_cPlaca = MVEH_cPlaca;
			this.MVEH_cTPropiedad = MVEH_cTPropiedad;
			this.MVEH_nIdMProveedor = MVEH_nIdMProveedor;
			this.MVEH_nIdMModelo = MVEH_nIdMModelo;
			this.MVEH_lActivo = MVEH_lActivo;
			this.MVEH_nUsrReg = MVEH_nUsrReg;
			this.MVEH_dFechReg = MVEH_dFechReg;
			this.MVEH_nUsrMod = MVEH_nUsrMod;
			this.MVEH_dFechMod = MVEH_dFechMod;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MVehiculo class.
		/// </summary>
		public ENT_MVehiculo(int MVEH_nId, string MVEH_cPlaca, string MVEH_cTPropiedad, int MVEH_nIdMProveedor, int MVEH_nIdMModelo, bool MVEH_lActivo, int MVEH_nUsrReg, DateTime MVEH_dFechReg, int MVEH_nUsrMod, DateTime MVEH_dFechMod)
		{
			this.MVEH_nId = MVEH_nId;
			this.MVEH_cPlaca = MVEH_cPlaca;
			this.MVEH_cTPropiedad = MVEH_cTPropiedad;
			this.MVEH_nIdMProveedor = MVEH_nIdMProveedor;
			this.MVEH_nIdMModelo = MVEH_nIdMModelo;
			this.MVEH_lActivo = MVEH_lActivo;
			this.MVEH_nUsrReg = MVEH_nUsrReg;
			this.MVEH_dFechReg = MVEH_dFechReg;
			this.MVEH_nUsrMod = MVEH_nUsrMod;
			this.MVEH_dFechMod = MVEH_dFechMod;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MVEH_nId value. 
		/// </summary>
		public int MVEH_nId { get; set; }

		/// <summary>
		/// Gets or sets the MVEH_cPlaca value. 
		/// </summary>
		public string MVEH_cPlaca { get; set; }

		/// <summary>
		/// Gets or sets the MVEH_cTPropiedad value. 
		/// </summary>
		public string MVEH_cTPropiedad { get; set; }

		/// <summary>
		/// Gets or sets the MVEH_nIdMProveedor value. 
		/// </summary>
		public int MVEH_nIdMProveedor { get; set; }

		/// <summary>
		/// Gets or sets the MVEH_nIdMModelo value. 
		/// </summary>
		public int MVEH_nIdMModelo { get; set; }

		/// <summary>
		/// Gets or sets the MVEH_lActivo value. 
		/// </summary>
		public bool MVEH_lActivo { get; set; }

		/// <summary>
		/// Gets or sets the MVEH_nUsrReg value. 
		/// </summary>
		public int MVEH_nUsrReg { get; set; }

		/// <summary>
		/// Gets or sets the MVEH_dFechReg value. 
		/// </summary>
		public DateTime MVEH_dFechReg { get; set; }

		/// <summary>
		/// Gets or sets the MVEH_nUsrMod value. 
		/// </summary>
		public int MVEH_nUsrMod { get; set; }

		/// <summary>
		/// Gets or sets the MVEH_dFechMod value. 
		/// </summary>
		public DateTime MVEH_dFechMod { get; set; }

		#endregion
	}
}
