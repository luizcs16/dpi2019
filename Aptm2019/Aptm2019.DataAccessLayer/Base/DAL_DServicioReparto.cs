using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_DServicioReparto : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla DServicioReparto.
		/// </summary>
		public void Insert(ENT_DServicioReparto x_oENT_DServicioReparto)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DSVRP_nIdMServicioReparto", x_oENT_DServicioReparto.DSVRP_nIdMServicioReparto),
					new SqlParameter("@DSVRP_nIdMEmpleado", x_oENT_DServicioReparto.DSVRP_nIdMEmpleado),
					new SqlParameter("@DSVRP_lActivo", x_oENT_DServicioReparto.DSVRP_lActivo),
					new SqlParameter("@DSVRP_nUsrReg", x_oENT_DServicioReparto.DSVRP_nUsrReg),
					new SqlParameter("@DSVRP_dFechReg", x_oENT_DServicioReparto.DSVRP_dFechReg),
					new SqlParameter("@DSVRP_nUsrMod", x_oENT_DServicioReparto.DSVRP_nUsrMod),
					new SqlParameter("@DSVRP_dFechMod", x_oENT_DServicioReparto.DSVRP_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_DServicioReparto.DSVRP_nId = (int)ejecutarScalar("spDServicioReparto_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla DServicioReparto.
		/// </summary>
		public void Update(ENT_DServicioReparto x_oENT_DServicioReparto)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DSVRP_nId", x_oENT_DServicioReparto.DSVRP_nId),
					new SqlParameter("@DSVRP_nIdMServicioReparto", x_oENT_DServicioReparto.DSVRP_nIdMServicioReparto),
					new SqlParameter("@DSVRP_nIdMEmpleado", x_oENT_DServicioReparto.DSVRP_nIdMEmpleado),
					new SqlParameter("@DSVRP_lActivo", x_oENT_DServicioReparto.DSVRP_lActivo),
					new SqlParameter("@DSVRP_nUsrReg", x_oENT_DServicioReparto.DSVRP_nUsrReg),
					new SqlParameter("@DSVRP_dFechReg", x_oENT_DServicioReparto.DSVRP_dFechReg),
					new SqlParameter("@DSVRP_nUsrMod", x_oENT_DServicioReparto.DSVRP_nUsrMod),
					new SqlParameter("@DSVRP_dFechMod", x_oENT_DServicioReparto.DSVRP_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spDServicioReparto_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla DServicioReparto por su primary key.
		/// </summary>
		public void Delete(int DSVRP_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DSVRP_nId", DSVRP_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spDServicioReparto_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the DServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByDSVRP_nIdMEmpleado(int DSVRP_nIdMEmpleado)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DSVRP_nIdMEmpleado", DSVRP_nIdMEmpleado)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spDServicioRepartoDeleteAllByDSVRP_nIdMEmpleado", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the DServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByDSVRP_nIdMServicioReparto(int DSVRP_nIdMServicioReparto)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DSVRP_nIdMServicioReparto", DSVRP_nIdMServicioReparto)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spDServicioRepartoDeleteAllByDSVRP_nIdMServicioReparto", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the DServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByDSVRP_nUsrReg(int DSVRP_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DSVRP_nUsrReg", DSVRP_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spDServicioRepartoDeleteAllByDSVRP_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the DServicioReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByDSVRP_nUsrMod(int DSVRP_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DSVRP_nUsrMod", DSVRP_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spDServicioRepartoDeleteAllByDSVRP_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla DServicioReparto por su primary key.
		/// </summary>
		public ENT_DServicioReparto Select(int DSVRP_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DSVRP_nId", DSVRP_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_DServicioReparto objDServicioReparto = new ENT_DServicioReparto();
			try{
					 objDServicioReparto = GetEntity<ENT_DServicioReparto>("spDServicioReparto_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objDServicioReparto;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla DServicioReparto.
		/// </summary>
		public List<ENT_DServicioReparto> SelectAll()
		{

			try{
				List<ENT_DServicioReparto> x_oENT_DServicioRepartoList = new List<ENT_DServicioReparto>();

				x_oENT_DServicioRepartoList = GetList<ENT_DServicioReparto>("spDServicioReparto_SelectAll");
				return x_oENT_DServicioRepartoList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla DServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_DServicioReparto> SelectAllByDSVRP_nIdMEmpleado(int DSVRP_nIdMEmpleado)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@DSVRP_nIdMEmpleado", DSVRP_nIdMEmpleado)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_DServicioReparto> x_oENT_DServicioRepartoList = new List<ENT_DServicioReparto>();

			try{
					x_oENT_DServicioRepartoList = GetList<ENT_DServicioReparto>("spDServicioRepartoSelectAllByDSVRP_nIdMEmpleado", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_DServicioRepartoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla DServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_DServicioReparto> SelectAllByDSVRP_nIdMServicioReparto(int DSVRP_nIdMServicioReparto)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@DSVRP_nIdMServicioReparto", DSVRP_nIdMServicioReparto)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_DServicioReparto> x_oENT_DServicioRepartoList = new List<ENT_DServicioReparto>();

			try{
					x_oENT_DServicioRepartoList = GetList<ENT_DServicioReparto>("spDServicioRepartoSelectAllByDSVRP_nIdMServicioReparto", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_DServicioRepartoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla DServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_DServicioReparto> SelectAllByDSVRP_nUsrReg(int DSVRP_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@DSVRP_nUsrReg", DSVRP_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_DServicioReparto> x_oENT_DServicioRepartoList = new List<ENT_DServicioReparto>();

			try{
					x_oENT_DServicioRepartoList = GetList<ENT_DServicioReparto>("spDServicioRepartoSelectAllByDSVRP_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_DServicioRepartoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla DServicioReparto por un foreign key.
		/// </summary>
		public List<ENT_DServicioReparto> SelectAllByDSVRP_nUsrMod(int DSVRP_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@DSVRP_nUsrMod", DSVRP_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_DServicioReparto> x_oENT_DServicioRepartoList = new List<ENT_DServicioReparto>();

			try{
					x_oENT_DServicioRepartoList = GetList<ENT_DServicioReparto>("spDServicioRepartoSelectAllByDSVRP_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_DServicioRepartoList;
		}


		#endregion
	}
}
