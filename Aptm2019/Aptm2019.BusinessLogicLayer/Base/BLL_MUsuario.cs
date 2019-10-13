using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MUsuario
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MUsuario.
		/// </summary>
		public void Insert(ENT_MUsuario x_oENT_MUsuario)
		{
			 new DAL_MUsuario().Insert(x_oENT_MUsuario);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MUsuario.
		/// </summary>
		public void Update(ENT_MUsuario x_oENT_MUsuario)
		{
			 new DAL_MUsuario().Update(x_oENT_MUsuario);
		}

		/// <summary>
		/// Elimina un registro de la tabla MUsuario por su primary key.
		/// </summary>
		public void Delete(int MUSR_nId)
		{
			 new DAL_MUsuario().Delete(MUSR_nId);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MUsuario por su primary key.
		/// </summary>
		public ENT_MUsuario Select(int MUSR_nId)
		{
			return new DAL_MUsuario().Select(MUSR_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MUsuario.
		/// </summary>
		public List<ENT_MUsuario> SelectAll()
		{
			 return new DAL_MUsuario().SelectAll();
		}


		#endregion
	}
}
