using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MUsuario
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_MUsuario class.
		/// </summary>
		public ENT_MUsuario()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MUsuario class.
		/// </summary>
		public ENT_MUsuario(string MUSR_cUsuario, string MUSR_cPassword, bool MUSR_lActivo)
		{
			this.MUSR_cUsuario = MUSR_cUsuario;
			this.MUSR_cPassword = MUSR_cPassword;
			this.MUSR_lActivo = MUSR_lActivo;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MUsuario class.
		/// </summary>
		public ENT_MUsuario(int MUSR_nId, string MUSR_cUsuario, string MUSR_cPassword, bool MUSR_lActivo)
		{
			this.MUSR_nId = MUSR_nId;
			this.MUSR_cUsuario = MUSR_cUsuario;
			this.MUSR_cPassword = MUSR_cPassword;
			this.MUSR_lActivo = MUSR_lActivo;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MUSR_nId value. 
		/// </summary>
		public int MUSR_nId { get; set; }

		/// <summary>
		/// Gets or sets the MUSR_cUsuario value. 
		/// </summary>
		public string MUSR_cUsuario { get; set; }

		/// <summary>
		/// Gets or sets the MUSR_cPassword value. 
		/// </summary>
		public string MUSR_cPassword { get; set; }

		/// <summary>
		/// Gets or sets the MUSR_lActivo value. 
		/// </summary>
		public bool MUSR_lActivo { get; set; }

		#endregion
	}
}
