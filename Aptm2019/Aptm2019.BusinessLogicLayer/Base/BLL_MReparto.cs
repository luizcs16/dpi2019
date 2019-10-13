using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MReparto
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MReparto.
		/// </summary>
		public void Insert(ENT_MReparto x_oENT_MReparto)
		{
			 new DAL_MReparto().Insert(x_oENT_MReparto);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MReparto.
		/// </summary>
		public void Update(ENT_MReparto x_oENT_MReparto)
		{
			 new DAL_MReparto().Update(x_oENT_MReparto);
		}

		/// <summary>
		/// Elimina un registro de la tabla MReparto por su primary key.
		/// </summary>
		public void Delete(int MRPT_nId)
		{
			 new DAL_MReparto().Delete(MRPT_nId);
		}

		/// <summary>
		/// Deletes a record from the MReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPT_nIdServicioReparto(int MRPT_nIdServicioReparto)
		{
			 new DAL_MReparto().DeleteAllByMRPT_nIdServicioReparto(MRPT_nIdServicioReparto);
		}

		/// <summary>
		/// Deletes a record from the MReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPT_nUsrReg(int MRPT_nUsrReg)
		{
			 new DAL_MReparto().DeleteAllByMRPT_nUsrReg(MRPT_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the MReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPT_nUsrMod(int MRPT_nUsrMod)
		{
			 new DAL_MReparto().DeleteAllByMRPT_nUsrMod(MRPT_nUsrMod);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MReparto por su primary key.
		/// </summary>
		public ENT_MReparto Select(int MRPT_nId)
		{
			return new DAL_MReparto().Select(MRPT_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MReparto.
		/// </summary>
		public List<ENT_MReparto> SelectAll()
		{
			 return new DAL_MReparto().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla MReparto por un foreign key.
		/// </summary>
		public List<ENT_MReparto> SelectAllByMRPT_nIdServicioReparto(int MRPT_nIdServicioReparto)
		{
			return new DAL_MReparto().SelectAllByMRPT_nIdServicioReparto(MRPT_nIdServicioReparto);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MReparto por un foreign key.
		/// </summary>
		public List<ENT_MReparto> SelectAllByMRPT_nUsrReg(int MRPT_nUsrReg)
		{
			return new DAL_MReparto().SelectAllByMRPT_nUsrReg(MRPT_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MReparto por un foreign key.
		/// </summary>
		public List<ENT_MReparto> SelectAllByMRPT_nUsrMod(int MRPT_nUsrMod)
		{
			return new DAL_MReparto().SelectAllByMRPT_nUsrMod(MRPT_nUsrMod);
		}


		#endregion
	}
}
