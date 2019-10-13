using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_MServicioReparto : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MServicioReparto.
		/// </summary>
		public void Insert(ENT_MServicioReparto x_oENT_MServicioReparto)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSVRP_nIdMServicio", x_oENT_MServicioReparto.MSVRP_nIdMServicio),
					new SqlParameter("@MSVRP_nIdMVehiculo", x_oENT_MServicioReparto.MSVRP_nIdMVehiculo),
					new SqlParameter("@MSVRP_lActivo", x_oENT_MServicioReparto.MSVRP_lActivo),
					new SqlParameter("@MSVRP_nUsrReg", x_oENT_MServicioReparto.MSVRP_nUsrReg),
					new SqlParameter("@MSVRP_dFechReg", x_oENT_MServicioReparto.MSVRP_dFechReg),
					new SqlParameter("@MSVRP_nUsrMod", x_oENT_MServicioReparto.MSVRP_nUsrMod),
					new SqlParameter("@MSVRP_dFechMod", x_oENT_MServicioReparto.MSVRP_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MServicioReparto.MSVRP_nId = (int)ejecutarScalar("spMServicioReparto_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MServicioReparto.
		/// </summary>
		public void Update(ENT_MServicioReparto x_oENT_MServicioReparto)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSVRP_nId", x_oENT_MServicioReparto.MSVRP_nId),
					new SqlParameter("@MSVRP_nIdMServicio", x_oENT_MServicioReparto.MSVRP_nIdMServicio),
					new SqlParameter("@MSVRP_nIdMVehiculo", x_oENT_MServicioReparto.MSVRP_nIdMVehiculo),
					new SqlParameter("@MSVRP_lActivo", x_oENT_MServicioReparto.MSVRP_lActivo),
					new SqlParameter("@MSVRP_nUsrReg", x_oENT_MServicioReparto.MSVRP_nUsrReg),
					new SqlParameter("@MSVRP_dFechReg", x_oENT_MServicioReparto.MSVRP_dFechReg),
					new SqlParameter("@MSVRP_nUsrMod", x_oENT_MServicioReparto.MSVRP_nUsrMod),
					new SqlParameter("@MSVRP_dFechMod", x_oENT_MServicioReparto.MSVRP_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMServicioReparto_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MServicioReparto por su primary key.
		/// </summary>
		public void Delete(int MSVRP_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSVRP_nId", MSVRP_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMServicioReparto_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMSVRP_nIdMServicio(int MSVRP_nIdMServicio)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSVRP_nIdMServicio", MSVRP_nIdMServicio)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMServicioRepartoDeleteAllByMSVRP_nIdMServicio", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMSVRP_nUsrReg(int MSVRP_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSVRP_nUsrReg", MSVRP_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMServicioRepartoDeleteAllByMSVRP_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMSVRP_nUsrMod(int MSVRP_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSVRP_nUsrMod", MSVRP_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMServicioRepartoDeleteAllByMSVRP_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMSVRP_nIdMVehiculo(int MSVRP_nIdMVehiculo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSVRP_nIdMVehiculo", MSVRP_nIdMVehiculo)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMServicioRepartoDeleteAllByMSVRP_nIdMVehiculo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MServicioReparto por su primary key.
		/// </summary>
		public ENT_MServicioReparto Select(int MSVRP_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSVRP_nId", MSVRP_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MServicioReparto objMServicioReparto = new ENT_MServicioReparto();
			try{
					 objMServicioReparto = GetEntity<ENT_MServicioReparto>("spMServicioReparto_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMServicioReparto;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MServicioReparto.
		/// </summary>
		public List<ENT_MServicioReparto> SelectAll()
		{

			try{
				List<ENT_MServicioReparto> x_oENT_MServicioRepartoList = new List<ENT_MServicioReparto>();

				x_oENT_MServicioRepartoList = GetList<ENT_MServicioReparto>("spMServicioReparto_SelectAll");
				return x_oENT_MServicioRepartoList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_MServicioReparto> SelectAllByMSVRP_nIdMServicio(int MSVRP_nIdMServicio)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MSVRP_nIdMServicio", MSVRP_nIdMServicio)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MServicioReparto> x_oENT_MServicioRepartoList = new List<ENT_MServicioReparto>();

			try{
					x_oENT_MServicioRepartoList = GetList<ENT_MServicioReparto>("spMServicioRepartoSelectAllByMSVRP_nIdMServicio", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MServicioRepartoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_MServicioReparto> SelectAllByMSVRP_nUsrReg(int MSVRP_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MSVRP_nUsrReg", MSVRP_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MServicioReparto> x_oENT_MServicioRepartoList = new List<ENT_MServicioReparto>();

			try{
					x_oENT_MServicioRepartoList = GetList<ENT_MServicioReparto>("spMServicioRepartoSelectAllByMSVRP_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MServicioRepartoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_MServicioReparto> SelectAllByMSVRP_nUsrMod(int MSVRP_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MSVRP_nUsrMod", MSVRP_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MServicioReparto> x_oENT_MServicioRepartoList = new List<ENT_MServicioReparto>();

			try{
					x_oENT_MServicioRepartoList = GetList<ENT_MServicioReparto>("spMServicioRepartoSelectAllByMSVRP_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MServicioRepartoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_MServicioReparto> SelectAllByMSVRP_nIdMVehiculo(int MSVRP_nIdMVehiculo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MSVRP_nIdMVehiculo", MSVRP_nIdMVehiculo)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MServicioReparto> x_oENT_MServicioRepartoList = new List<ENT_MServicioReparto>();

			try{
					x_oENT_MServicioRepartoList = GetList<ENT_MServicioReparto>("spMServicioRepartoSelectAllByMSVRP_nIdMVehiculo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MServicioRepartoList;
		}


		#endregion
	}
}
