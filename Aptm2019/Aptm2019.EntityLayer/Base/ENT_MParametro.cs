using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MParametro
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_MParametro class.
		/// </summary>
		public ENT_MParametro()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MParametro class.
		/// </summary>
		public ENT_MParametro(string MPAR_cDescripcion, int MPAR_nMasterId, bool MPAR_lActivo, int MPAR_nUsrReg, DateTime MPAR_dFechReg, int MPAR_nUsrMod, DateTime MPAR_dFechMod)
		{
			this.MPAR_cDescripcion = MPAR_cDescripcion;
			this.MPAR_nMasterId = MPAR_nMasterId;
			this.MPAR_lActivo = MPAR_lActivo;
			this.MPAR_nUsrReg = MPAR_nUsrReg;
			this.MPAR_dFechReg = MPAR_dFechReg;
			this.MPAR_nUsrMod = MPAR_nUsrMod;
			this.MPAR_dFechMod = MPAR_dFechMod;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MParametro class.
		/// </summary>
		public ENT_MParametro(int MPAR_nId, string MPAR_cDescripcion, int MPAR_nMasterId, bool MPAR_lActivo, int MPAR_nUsrReg, DateTime MPAR_dFechReg, int MPAR_nUsrMod, DateTime MPAR_dFechMod)
		{
			this.MPAR_nId = MPAR_nId;
			this.MPAR_cDescripcion = MPAR_cDescripcion;
			this.MPAR_nMasterId = MPAR_nMasterId;
			this.MPAR_lActivo = MPAR_lActivo;
			this.MPAR_nUsrReg = MPAR_nUsrReg;
			this.MPAR_dFechReg = MPAR_dFechReg;
			this.MPAR_nUsrMod = MPAR_nUsrMod;
			this.MPAR_dFechMod = MPAR_dFechMod;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MPAR_nId value. 
		/// </summary>
		public int MPAR_nId { get; set; }

		/// <summary>
		/// Gets or sets the MPAR_cDescripcion value. 
		/// </summary>
		public string MPAR_cDescripcion { get; set; }

		/// <summary>
		/// Gets or sets the MPAR_nMasterId value. 
		/// </summary>
		public int MPAR_nMasterId { get; set; }

		/// <summary>
		/// Gets or sets the MPAR_lActivo value. 
		/// </summary>
		public bool MPAR_lActivo { get; set; }

		/// <summary>
		/// Gets or sets the MPAR_nUsrReg value. 
		/// </summary>
		public int MPAR_nUsrReg { get; set; }

		/// <summary>
		/// Gets or sets the MPAR_dFechReg value. 
		/// </summary>
		public DateTime MPAR_dFechReg { get; set; }

		/// <summary>
		/// Gets or sets the MPAR_nUsrMod value. 
		/// </summary>
		public int MPAR_nUsrMod { get; set; }

		/// <summary>
		/// Gets or sets the MPAR_dFechMod value. 
		/// </summary>
		public DateTime MPAR_dFechMod { get; set; }

		#endregion
	}
}
