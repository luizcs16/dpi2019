using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MRepartoMarker
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MRepartoMarker.
		/// </summary>
		public void Insert(ENT_MRepartoMarker x_oENT_MRepartoMarker)
		{
			 new DAL_MRepartoMarker().Insert(x_oENT_MRepartoMarker);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MRepartoMarker.
		/// </summary>
		public void Update(ENT_MRepartoMarker x_oENT_MRepartoMarker)
		{
			 new DAL_MRepartoMarker().Update(x_oENT_MRepartoMarker);
		}

		/// <summary>
		/// Elimina un registro de la tabla MRepartoMarker por su primary key.
		/// </summary>
		public void Delete(int MRPMK_nId)
		{
			 new DAL_MRepartoMarker().Delete(MRPMK_nId);
		}

		/// <summary>
		/// Deletes a record from the MRepartoMarker table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPMK_nIdMReparto(int MRPMK_nIdMReparto)
		{
			 new DAL_MRepartoMarker().DeleteAllByMRPMK_nIdMReparto(MRPMK_nIdMReparto);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MRepartoMarker por su primary key.
		/// </summary>
		public ENT_MRepartoMarker Select(int MRPMK_nId)
		{
			return new DAL_MRepartoMarker().Select(MRPMK_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MRepartoMarker.
		/// </summary>
		public List<ENT_MRepartoMarker> SelectAll()
		{
			 return new DAL_MRepartoMarker().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla MRepartoMarker por un foreign key.
		/// </summary>
		public List<ENT_MRepartoMarker> SelectAllByMRPMK_nIdMReparto(int MRPMK_nIdMReparto)
		{
			return new DAL_MRepartoMarker().SelectAllByMRPMK_nIdMReparto(MRPMK_nIdMReparto);
		}


		#endregion
	}
}
