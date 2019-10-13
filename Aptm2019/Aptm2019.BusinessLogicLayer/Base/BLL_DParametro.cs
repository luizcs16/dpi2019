using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_DParametro
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla DParametro.
		/// </summary>
		public void Insert(ENT_DParametro x_oENT_DParametro)
		{
			 new DAL_DParametro().Insert(x_oENT_DParametro);
		}

		/// <summary>
		/// Actualiza a registro de la tabla DParametro.
		/// </summary>
		public void Update(ENT_DParametro x_oENT_DParametro)
		{
			 new DAL_DParametro().Update(x_oENT_DParametro);
		}

		/// <summary>
		/// Elimina un registro de la tabla DParametro por su primary key.
		/// </summary>
		public void Delete(int DPAR_nId)
		{
			 new DAL_DParametro().Delete(DPAR_nId);
		}

		/// <summary>
		/// Deletes a record from the DParametro table by a foreign key.
		/// </summary>
		public void DeleteAllByDPAR_nIdMParametro(int DPAR_nIdMParametro)
		{
			 new DAL_DParametro().DeleteAllByDPAR_nIdMParametro(DPAR_nIdMParametro);
		}

		/// <summary>
		/// Deletes a record from the DParametro table by a foreign key.
		/// </summary>
		public void DeleteAllByDPAR_nUsrReg(int DPAR_nUsrReg)
		{
			 new DAL_DParametro().DeleteAllByDPAR_nUsrReg(DPAR_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the DParametro table by a foreign key.
		/// </summary>
		public void DeleteAllByDPAR_nUsrMod(int DPAR_nUsrMod)
		{
			 new DAL_DParametro().DeleteAllByDPAR_nUsrMod(DPAR_nUsrMod);
		}

		/// <summary>
		/// Selecciona una registro de la tabla DParametro por su primary key.
		/// </summary>
		public ENT_DParametro Select(int DPAR_nId)
		{
			return new DAL_DParametro().Select(DPAR_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla DParametro.
		/// </summary>
		public List<ENT_DParametro> SelectAll()
		{
			 return new DAL_DParametro().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla DParametro por un foreign key.
		/// </summary>
		public List<ENT_DParametro> SelectAllByDPAR_nIdMParametro(int DPAR_nIdMParametro)
		{
			return new DAL_DParametro().SelectAllByDPAR_nIdMParametro(DPAR_nIdMParametro);
		}

		/// <summary>
		/// Selecciona los registros de la tabla DParametro por un foreign key.
		/// </summary>
		public List<ENT_DParametro> SelectAllByDPAR_nUsrReg(int DPAR_nUsrReg)
		{
			return new DAL_DParametro().SelectAllByDPAR_nUsrReg(DPAR_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla DParametro por un foreign key.
		/// </summary>
		public List<ENT_DParametro> SelectAllByDPAR_nUsrMod(int DPAR_nUsrMod)
		{
			return new DAL_DParametro().SelectAllByDPAR_nUsrMod(DPAR_nUsrMod);
		}


		#endregion
	}
}
