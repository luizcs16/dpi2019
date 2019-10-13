using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MParametro
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MParametro.
		/// </summary>
		public void Insert(ENT_MParametro x_oENT_MParametro)
		{
			 new DAL_MParametro().Insert(x_oENT_MParametro);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MParametro.
		/// </summary>
		public void Update(ENT_MParametro x_oENT_MParametro)
		{
			 new DAL_MParametro().Update(x_oENT_MParametro);
		}

		/// <summary>
		/// Elimina un registro de la tabla MParametro por su primary key.
		/// </summary>
		public void Delete(int MPAR_nId)
		{
			 new DAL_MParametro().Delete(MPAR_nId);
		}

		/// <summary>
		/// Deletes a record from the MParametro table by a foreign key.
		/// </summary>
		public void DeleteAllByMPAR_nMasterId(int MPAR_nMasterId)
		{
			 new DAL_MParametro().DeleteAllByMPAR_nMasterId(MPAR_nMasterId);
		}

		/// <summary>
		/// Deletes a record from the MParametro table by a foreign key.
		/// </summary>
		public void DeleteAllByMPAR_nUsrReg(int MPAR_nUsrReg)
		{
			 new DAL_MParametro().DeleteAllByMPAR_nUsrReg(MPAR_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the MParametro table by a foreign key.
		/// </summary>
		public void DeleteAllByMPAR_nUsrMod(int MPAR_nUsrMod)
		{
			 new DAL_MParametro().DeleteAllByMPAR_nUsrMod(MPAR_nUsrMod);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MParametro por su primary key.
		/// </summary>
		public ENT_MParametro Select(int MPAR_nId)
		{
			return new DAL_MParametro().Select(MPAR_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MParametro.
		/// </summary>
		public List<ENT_MParametro> SelectAll()
		{
			 return new DAL_MParametro().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla MParametro por un foreign key.
		/// </summary>
		public List<ENT_MParametro> SelectAllByMPAR_nMasterId(int MPAR_nMasterId)
		{
			return new DAL_MParametro().SelectAllByMPAR_nMasterId(MPAR_nMasterId);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MParametro por un foreign key.
		/// </summary>
		public List<ENT_MParametro> SelectAllByMPAR_nUsrReg(int MPAR_nUsrReg)
		{
			return new DAL_MParametro().SelectAllByMPAR_nUsrReg(MPAR_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MParametro por un foreign key.
		/// </summary>
		public List<ENT_MParametro> SelectAllByMPAR_nUsrMod(int MPAR_nUsrMod)
		{
			return new DAL_MParametro().SelectAllByMPAR_nUsrMod(MPAR_nUsrMod);
		}


		#endregion
	}
}
