using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MModelo
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_MModelo class.
		/// </summary>
		public ENT_MModelo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MModelo class.
		/// </summary>
		public ENT_MModelo(int MMDLO_nIdMMarca, string MMDLO_cDescripcion, int MMDLO_nUsrReg, DateTime MMDLO_dFechReg, int MMDLO_nUsrMod, DateTime MMDLO_dFechMod)
		{
			this.MMDLO_nIdMMarca = MMDLO_nIdMMarca;
			this.MMDLO_cDescripcion = MMDLO_cDescripcion;
			this.MMDLO_nUsrReg = MMDLO_nUsrReg;
			this.MMDLO_dFechReg = MMDLO_dFechReg;
			this.MMDLO_nUsrMod = MMDLO_nUsrMod;
			this.MMDLO_dFechMod = MMDLO_dFechMod;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MModelo class.
		/// </summary>
		public ENT_MModelo(int MMDLO_nId, int MMDLO_nIdMMarca, string MMDLO_cDescripcion, int MMDLO_nUsrReg, DateTime MMDLO_dFechReg, int MMDLO_nUsrMod, DateTime MMDLO_dFechMod)
		{
			this.MMDLO_nId = MMDLO_nId;
			this.MMDLO_nIdMMarca = MMDLO_nIdMMarca;
			this.MMDLO_cDescripcion = MMDLO_cDescripcion;
			this.MMDLO_nUsrReg = MMDLO_nUsrReg;
			this.MMDLO_dFechReg = MMDLO_dFechReg;
			this.MMDLO_nUsrMod = MMDLO_nUsrMod;
			this.MMDLO_dFechMod = MMDLO_dFechMod;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MMDLO_nId value. 
		/// </summary>
		public int MMDLO_nId { get; set; }

		/// <summary>
		/// Gets or sets the MMDLO_nIdMMarca value. 
		/// </summary>
		public int MMDLO_nIdMMarca { get; set; }

		/// <summary>
		/// Gets or sets the MMDLO_cDescripcion value. 
		/// </summary>
		public string MMDLO_cDescripcion { get; set; }

		/// <summary>
		/// Gets or sets the MMDLO_nUsrReg value. 
		/// </summary>
		public int MMDLO_nUsrReg { get; set; }

		/// <summary>
		/// Gets or sets the MMDLO_dFechReg value. 
		/// </summary>
		public DateTime MMDLO_dFechReg { get; set; }

		/// <summary>
		/// Gets or sets the MMDLO_nUsrMod value. 
		/// </summary>
		public int MMDLO_nUsrMod { get; set; }

		/// <summary>
		/// Gets or sets the MMDLO_dFechMod value. 
		/// </summary>
		public DateTime MMDLO_dFechMod { get; set; }

		#endregion
	}
}
