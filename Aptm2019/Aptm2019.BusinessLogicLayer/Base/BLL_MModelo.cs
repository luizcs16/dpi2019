using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MModelo
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MModelo.
		/// </summary>
		public void Insert(ENT_MModelo x_oENT_MModelo)
		{
			 new DAL_MModelo().Insert(x_oENT_MModelo);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MModelo.
		/// </summary>
		public void Update(ENT_MModelo x_oENT_MModelo)
		{
			 new DAL_MModelo().Update(x_oENT_MModelo);
		}

		/// <summary>
		/// Elimina un registro de la tabla MModelo por su primary key.
		/// </summary>
		public void Delete(int MMDLO_nId)
		{
			 new DAL_MModelo().Delete(MMDLO_nId);
		}

		/// <summary>
		/// Deletes a record from the MModelo table by a foreign key.
		/// </summary>
		public void DeleteAllByMMDLO_nIdMMarca(int MMDLO_nIdMMarca)
		{
			 new DAL_MModelo().DeleteAllByMMDLO_nIdMMarca(MMDLO_nIdMMarca);
		}

		/// <summary>
		/// Deletes a record from the MModelo table by a foreign key.
		/// </summary>
		public void DeleteAllByMMDLO_nUsrReg(int MMDLO_nUsrReg)
		{
			 new DAL_MModelo().DeleteAllByMMDLO_nUsrReg(MMDLO_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the MModelo table by a foreign key.
		/// </summary>
		public void DeleteAllByMMDLO_nUsrMod(int MMDLO_nUsrMod)
		{
			 new DAL_MModelo().DeleteAllByMMDLO_nUsrMod(MMDLO_nUsrMod);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MModelo por su primary key.
		/// </summary>
		public ENT_MModelo Select(int MMDLO_nId)
		{
			return new DAL_MModelo().Select(MMDLO_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MModelo.
		/// </summary>
		public List<ENT_MModelo> SelectAll()
		{
			 return new DAL_MModelo().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla MModelo por un foreign key.
		/// </summary>
		public List<ENT_MModelo> SelectAllByMMDLO_nIdMMarca(int MMDLO_nIdMMarca)
		{
			return new DAL_MModelo().SelectAllByMMDLO_nIdMMarca(MMDLO_nIdMMarca);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MModelo por un foreign key.
		/// </summary>
		public List<ENT_MModelo> SelectAllByMMDLO_nUsrReg(int MMDLO_nUsrReg)
		{
			return new DAL_MModelo().SelectAllByMMDLO_nUsrReg(MMDLO_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MModelo por un foreign key.
		/// </summary>
		public List<ENT_MModelo> SelectAllByMMDLO_nUsrMod(int MMDLO_nUsrMod)
		{
			return new DAL_MModelo().SelectAllByMMDLO_nUsrMod(MMDLO_nUsrMod);
		}


		#endregion
	}
}
