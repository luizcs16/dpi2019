using System;

namespace Aptm2019.EntityLayer
{
	public class ENT_MRepartoMarker
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ENT_MRepartoMarker class.
		/// </summary>
		public ENT_MRepartoMarker()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MRepartoMarker class.
		/// </summary>
		public ENT_MRepartoMarker(int MRPMK_nIdMReparto, decimal MRPMK_nLat, decimal MRPMK_nLong, string MRPMK_cDireccion)
		{
			this.MRPMK_nIdMReparto = MRPMK_nIdMReparto;
			this.MRPMK_nLat = MRPMK_nLat;
			this.MRPMK_nLong = MRPMK_nLong;
			this.MRPMK_cDireccion = MRPMK_cDireccion;
		}

		/// <summary>
		/// Initializes a new instance of the ENT_MRepartoMarker class.
		/// </summary>
		public ENT_MRepartoMarker(int MRPMK_nId, int MRPMK_nIdMReparto, decimal MRPMK_nLat, decimal MRPMK_nLong, string MRPMK_cDireccion)
		{
			this.MRPMK_nId = MRPMK_nId;
			this.MRPMK_nIdMReparto = MRPMK_nIdMReparto;
			this.MRPMK_nLat = MRPMK_nLat;
			this.MRPMK_nLong = MRPMK_nLong;
			this.MRPMK_cDireccion = MRPMK_cDireccion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MRPMK_nId value. 
		/// </summary>
		public int MRPMK_nId { get; set; }

		/// <summary>
		/// Gets or sets the MRPMK_nIdMReparto value. 
		/// </summary>
		public int MRPMK_nIdMReparto { get; set; }

		/// <summary>
		/// Gets or sets the MRPMK_nLat value. 
		/// </summary>
		public decimal MRPMK_nLat { get; set; }

		/// <summary>
		/// Gets or sets the MRPMK_nLong value. 
		/// </summary>
		public decimal MRPMK_nLong { get; set; }

		/// <summary>
		/// Gets or sets the MRPMK_cDireccion value. 
		/// </summary>
		public string MRPMK_cDireccion { get; set; }

		#endregion
	}
}
