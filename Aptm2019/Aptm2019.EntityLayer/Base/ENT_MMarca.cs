using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MMarca
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_MMarca class.
		/// </summary>
		public ENT_MMarca()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MMarca class.
		/// </summary>
		public ENT_MMarca(string MMRCA_cDescripcion, int MMRCA_nUsrReg, DateTime MMRCA_dFechReg, int MMRCA_nUsrMod, DateTime MMRCA_dFechMod)
		{
			this.MMRCA_cDescripcion = MMRCA_cDescripcion;
			this.MMRCA_nUsrReg = MMRCA_nUsrReg;
			this.MMRCA_dFechReg = MMRCA_dFechReg;
			this.MMRCA_nUsrMod = MMRCA_nUsrMod;
			this.MMRCA_dFechMod = MMRCA_dFechMod;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MMarca class.
		/// </summary>
		public ENT_MMarca(int MMRCA_nId, string MMRCA_cDescripcion, int MMRCA_nUsrReg, DateTime MMRCA_dFechReg, int MMRCA_nUsrMod, DateTime MMRCA_dFechMod)
		{
			this.MMRCA_nId = MMRCA_nId;
			this.MMRCA_cDescripcion = MMRCA_cDescripcion;
			this.MMRCA_nUsrReg = MMRCA_nUsrReg;
			this.MMRCA_dFechReg = MMRCA_dFechReg;
			this.MMRCA_nUsrMod = MMRCA_nUsrMod;
			this.MMRCA_dFechMod = MMRCA_dFechMod;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MMRCA_nId value. 
		/// </summary>
		public int MMRCA_nId { get; set; }

		/// <summary>
		/// Gets or sets the MMRCA_cDescripcion value. 
		/// </summary>
		public string MMRCA_cDescripcion { get; set; }

		/// <summary>
		/// Gets or sets the MMRCA_nUsrReg value. 
		/// </summary>
		public int MMRCA_nUsrReg { get; set; }

		/// <summary>
		/// Gets or sets the MMRCA_dFechReg value. 
		/// </summary>
		public DateTime MMRCA_dFechReg { get; set; }

		/// <summary>
		/// Gets or sets the MMRCA_nUsrMod value. 
		/// </summary>
		public int MMRCA_nUsrMod { get; set; }

		/// <summary>
		/// Gets or sets the MMRCA_dFechMod value. 
		/// </summary>
		public DateTime MMRCA_dFechMod { get; set; }

		#endregion
	}
}
