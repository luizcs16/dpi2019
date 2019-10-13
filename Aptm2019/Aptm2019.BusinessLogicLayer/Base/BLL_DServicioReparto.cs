using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_DServicioReparto
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla DServicioReparto.
		/// </summary>
		public void Insert(ENT_DServicioReparto x_oENT_DServicioReparto)
		{
			 new DAL_DServicioReparto().Insert(x_oENT_DServicioReparto);
		}

		/// <summary>
		/// Actualiza a registro de la tabla DServicioReparto.
		/// </summary>
		public void Update(ENT_DServicioReparto x_oENT_DServicioReparto)
		{
			 new DAL_DServicioReparto().Update(x_oENT_DServicioReparto);
		}

		/// <summary>
		/// Elimina un registro de la tabla DServicioReparto por su primary key.
		/// </summary>
		public void Delete(int DSVRP_nId)
		{
			 new DAL_DServicioReparto().Delete(DSVRP_nId);
		}

		/// <summary>
		/// Deletes a record from the DServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByDSVRP_nIdMEmpleado(int DSVRP_nIdMEmpleado)
		{
			 new DAL_DServicioReparto().DeleteAllByDSVRP_nIdMEmpleado(DSVRP_nIdMEmpleado);
		}

		/// <summary>
		/// Deletes a record from the DServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByDSVRP_nIdMServicioReparto(int DSVRP_nIdMServicioReparto)
		{
			 new DAL_DServicioReparto().DeleteAllByDSVRP_nIdMServicioReparto(DSVRP_nIdMServicioReparto);
		}

		/// <summary>
		/// Deletes a record from the DServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByDSVRP_nUsrReg(int DSVRP_nUsrReg)
		{
			 new DAL_DServicioReparto().DeleteAllByDSVRP_nUsrReg(DSVRP_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the DServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByDSVRP_nUsrMod(int DSVRP_nUsrMod)
		{
			 new DAL_DServicioReparto().DeleteAllByDSVRP_nUsrMod(DSVRP_nUsrMod);
		}

		/// <summary>
		/// Selecciona una registro de la tabla DServicioReparto por su primary key.
		/// </summary>
		public ENT_DServicioReparto Select(int DSVRP_nId)
		{
			return new DAL_DServicioReparto().Select(DSVRP_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla DServicioReparto.
		/// </summary>
		public List<ENT_DServicioReparto> SelectAll()
		{
			 return new DAL_DServicioReparto().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla DServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_DServicioReparto> SelectAllByDSVRP_nIdMEmpleado(int DSVRP_nIdMEmpleado)
		{
			return new DAL_DServicioReparto().SelectAllByDSVRP_nIdMEmpleado(DSVRP_nIdMEmpleado);
		}

		/// <summary>
		/// Selecciona los registros de la tabla DServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_DServicioReparto> SelectAllByDSVRP_nIdMServicioReparto(int DSVRP_nIdMServicioReparto)
		{
			return new DAL_DServicioReparto().SelectAllByDSVRP_nIdMServicioReparto(DSVRP_nIdMServicioReparto);
		}

		/// <summary>
		/// Selecciona los registros de la tabla DServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_DServicioReparto> SelectAllByDSVRP_nUsrReg(int DSVRP_nUsrReg)
		{
			return new DAL_DServicioReparto().SelectAllByDSVRP_nUsrReg(DSVRP_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla DServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_DServicioReparto> SelectAllByDSVRP_nUsrMod(int DSVRP_nUsrMod)
		{
			return new DAL_DServicioReparto().SelectAllByDSVRP_nUsrMod(DSVRP_nUsrMod);
		}


		#endregion
	}
}
