using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_DParametro
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_DParametro class.
		/// </summary>
		public ENT_DParametro()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_DParametro class.
		/// </summary>
		public ENT_DParametro(int DPAR_nIdMParametro, string DPAR_cDescripcion, string DPAR_cValor, bool DPAR_lActivo, int DPAR_nUsrReg, DateTime DPAR_dFechReg, int DPAR_nUsrMod, DateTime DPAR_dFechMod)
		{
			this.DPAR_nIdMParametro = DPAR_nIdMParametro;
			this.DPAR_cDescripcion = DPAR_cDescripcion;
			this.DPAR_cValor = DPAR_cValor;
			this.DPAR_lActivo = DPAR_lActivo;
			this.DPAR_nUsrReg = DPAR_nUsrReg;
			this.DPAR_dFechReg = DPAR_dFechReg;
			this.DPAR_nUsrMod = DPAR_nUsrMod;
			this.DPAR_dFechMod = DPAR_dFechMod;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_DParametro class.
		/// </summary>
		public ENT_DParametro(int DPAR_nId, int DPAR_nIdMParametro, string DPAR_cDescripcion, string DPAR_cValor, bool DPAR_lActivo, int DPAR_nUsrReg, DateTime DPAR_dFechReg, int DPAR_nUsrMod, DateTime DPAR_dFechMod)
		{
			this.DPAR_nId = DPAR_nId;
			this.DPAR_nIdMParametro = DPAR_nIdMParametro;
			this.DPAR_cDescripcion = DPAR_cDescripcion;
			this.DPAR_cValor = DPAR_cValor;
			this.DPAR_lActivo = DPAR_lActivo;
			this.DPAR_nUsrReg = DPAR_nUsrReg;
			this.DPAR_dFechReg = DPAR_dFechReg;
			this.DPAR_nUsrMod = DPAR_nUsrMod;
			this.DPAR_dFechMod = DPAR_dFechMod;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DPAR_nId value. 
		/// </summary>
		public int DPAR_nId { get; set; }

		/// <summary>
		/// Gets or sets the DPAR_nIdMParametro value. 
		/// </summary>
		public int DPAR_nIdMParametro { get; set; }

		/// <summary>
		/// Gets or sets the DPAR_cDescripcion value. 
		/// </summary>
		public string DPAR_cDescripcion { get; set; }

		/// <summary>
		/// Gets or sets the DPAR_cValor value. 
		/// </summary>
		public string DPAR_cValor { get; set; }

		/// <summary>
		/// Gets or sets the DPAR_lActivo value. 
		/// </summary>
		public bool DPAR_lActivo { get; set; }

		/// <summary>
		/// Gets or sets the DPAR_nUsrReg value. 
		/// </summary>
		public int DPAR_nUsrReg { get; set; }

		/// <summary>
		/// Gets or sets the DPAR_dFechReg value. 
		/// </summary>
		public DateTime DPAR_dFechReg { get; set; }

		/// <summary>
		/// Gets or sets the DPAR_nUsrMod value. 
		/// </summary>
		public int DPAR_nUsrMod { get; set; }

		/// <summary>
		/// Gets or sets the DPAR_dFechMod value. 
		/// </summary>
		public DateTime DPAR_dFechMod { get; set; }

		#endregion
	}
}
