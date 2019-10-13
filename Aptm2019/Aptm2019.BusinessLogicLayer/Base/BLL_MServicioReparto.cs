using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MServicioReparto
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MServicioReparto.
		/// </summary>
		public void Insert(ENT_MServicioReparto x_oENT_MServicioReparto)
		{
			 new DAL_MServicioReparto().Insert(x_oENT_MServicioReparto);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MServicioReparto.
		/// </summary>
		public void Update(ENT_MServicioReparto x_oENT_MServicioReparto)
		{
			 new DAL_MServicioReparto().Update(x_oENT_MServicioReparto);
		}

		/// <summary>
		/// Elimina un registro de la tabla MServicioReparto por su primary key.
		/// </summary>
		public void Delete(int MSVRP_nId)
		{
			 new DAL_MServicioReparto().Delete(MSVRP_nId);
		}

		/// <summary>
		/// Deletes a record from the MServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMSVRP_nIdMServicio(int MSVRP_nIdMServicio)
		{
			 new DAL_MServicioReparto().DeleteAllByMSVRP_nIdMServicio(MSVRP_nIdMServicio);
		}

		/// <summary>
		/// Deletes a record from the MServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMSVRP_nUsrReg(int MSVRP_nUsrReg)
		{
			 new DAL_MServicioReparto().DeleteAllByMSVRP_nUsrReg(MSVRP_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the MServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMSVRP_nUsrMod(int MSVRP_nUsrMod)
		{
			 new DAL_MServicioReparto().DeleteAllByMSVRP_nUsrMod(MSVRP_nUsrMod);
		}

		/// <summary>
		/// Deletes a record from the MServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMSVRP_nIdMVehiculo(int MSVRP_nIdMVehiculo)
		{
			 new DAL_MServicioReparto().DeleteAllByMSVRP_nIdMVehiculo(MSVRP_nIdMVehiculo);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MServicioReparto por su primary key.
		/// </summary>
		public ENT_MServicioReparto Select(int MSVRP_nId)
		{
			return new DAL_MServicioReparto().Select(MSVRP_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MServicioReparto.
		/// </summary>
		public List<ENT_MServicioReparto> SelectAll()
		{
			 return new DAL_MServicioReparto().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_MServicioReparto> SelectAllByMSVRP_nIdMServicio(int MSVRP_nIdMServicio)
		{
			return new DAL_MServicioReparto().SelectAllByMSVRP_nIdMServicio(MSVRP_nIdMServicio);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_MServicioReparto> SelectAllByMSVRP_nUsrReg(int MSVRP_nUsrReg)
		{
			return new DAL_MServicioReparto().SelectAllByMSVRP_nUsrReg(MSVRP_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_MServicioReparto> SelectAllByMSVRP_nUsrMod(int MSVRP_nUsrMod)
		{
			return new DAL_MServicioReparto().SelectAllByMSVRP_nUsrMod(MSVRP_nUsrMod);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_MServicioReparto> SelectAllByMSVRP_nIdMVehiculo(int MSVRP_nIdMVehiculo)
		{
			return new DAL_MServicioReparto().SelectAllByMSVRP_nIdMVehiculo(MSVRP_nIdMVehiculo);
		}


		#endregion
	}
}
