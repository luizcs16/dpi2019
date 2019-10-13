using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MMarca
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MMarca.
		/// </summary>
		public void Insert(ENT_MMarca x_oENT_MMarca)
		{
			 new DAL_MMarca().Insert(x_oENT_MMarca);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MMarca.
		/// </summary>
		public void Update(ENT_MMarca x_oENT_MMarca)
		{
			 new DAL_MMarca().Update(x_oENT_MMarca);
		}

		/// <summary>
		/// Elimina un registro de la tabla MMarca por su primary key.
		/// </summary>
		public void Delete(int MMRCA_nId)
		{
			 new DAL_MMarca().Delete(MMRCA_nId);
		}

		/// <summary>
		/// Deletes a record from the MMarca table by a foreign key.
		/// </summary>
		public void DeleteAllByMMRCA_nUsrReg(int MMRCA_nUsrReg)
		{
			 new DAL_MMarca().DeleteAllByMMRCA_nUsrReg(MMRCA_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the MMarca table by a foreign key.
		/// </summary>
		public void DeleteAllByMMRCA_nUsrMod(int MMRCA_nUsrMod)
		{
			 new DAL_MMarca().DeleteAllByMMRCA_nUsrMod(MMRCA_nUsrMod);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MMarca por su primary key.
		/// </summary>
		public ENT_MMarca Select(int MMRCA_nId)
		{
			return new DAL_MMarca().Select(MMRCA_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MMarca.
		/// </summary>
		public List<ENT_MMarca> SelectAll()
		{
			 return new DAL_MMarca().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla MMarca por un foreign key.
		/// </summary>
		public List<ENT_MMarca> SelectAllByMMRCA_nUsrReg(int MMRCA_nUsrReg)
		{
			return new DAL_MMarca().SelectAllByMMRCA_nUsrReg(MMRCA_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MMarca por un foreign key.
		/// </summary>
		public List<ENT_MMarca> SelectAllByMMRCA_nUsrMod(int MMRCA_nUsrMod)
		{
			return new DAL_MMarca().SelectAllByMMRCA_nUsrMod(MMRCA_nUsrMod);
		}


		#endregion
	}
}
