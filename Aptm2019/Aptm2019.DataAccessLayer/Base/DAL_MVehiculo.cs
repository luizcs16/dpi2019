using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_MVehiculo : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MVehiculo.
		/// </summary>
		public void Insert(ENT_MVehiculo x_oENT_MVehiculo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MVEH_cPlaca", x_oENT_MVehiculo.MVEH_cPlaca),
					new SqlParameter("@MVEH_cTPropiedad", x_oENT_MVehiculo.MVEH_cTPropiedad),
					new SqlParameter("@MVEH_nIdMProveedor", x_oENT_MVehiculo.MVEH_nIdMProveedor),
					new SqlParameter("@MVEH_nIdMModelo", x_oENT_MVehiculo.MVEH_nIdMModelo),
					new SqlParameter("@MVEH_lActivo", x_oENT_MVehiculo.MVEH_lActivo),
					new SqlParameter("@MVEH_nUsrReg", x_oENT_MVehiculo.MVEH_nUsrReg),
					new SqlParameter("@MVEH_dFechReg", x_oENT_MVehiculo.MVEH_dFechReg),
					new SqlParameter("@MVEH_nUsrMod", x_oENT_MVehiculo.MVEH_nUsrMod),
					new SqlParameter("@MVEH_dFechMod", x_oENT_MVehiculo.MVEH_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MVehiculo.MVEH_nId = (int)ejecutarScalar("spMVehiculo_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MVehiculo.
		/// </summary>
		public void Update(ENT_MVehiculo x_oENT_MVehiculo)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MVEH_nId", x_oENT_MVehiculo.MVEH_nId),
					new SqlParameter("@MVEH_cPlaca", x_oENT_MVehiculo.MVEH_cPlaca),
					new SqlParameter("@MVEH_cTPropiedad", x_oENT_MVehiculo.MVEH_cTPropiedad),
					new SqlParameter("@MVEH_nIdMProveedor", x_oENT_MVehiculo.MVEH_nIdMProveedor),
					new SqlParameter("@MVEH_nIdMModelo", x_oENT_MVehiculo.MVEH_nIdMModelo),
					new SqlParameter("@MVEH_lActivo", x_oENT_MVehiculo.MVEH_lActivo),
					new SqlParameter("@MVEH_nUsrReg", x_oENT_MVehiculo.MVEH_nUsrReg),
					new SqlParameter("@MVEH_dFechReg", x_oENT_MVehiculo.MVEH_dFechReg),
					new SqlParameter("@MVEH_nUsrMod", x_oENT_MVehiculo.MVEH_nUsrMod),
					new SqlParameter("@MVEH_dFechMod", x_oENT_MVehiculo.MVEH_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMVehiculo_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MVehiculo por su primary key.
		/// </summary>
		public void Delete(int MVEH_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MVEH_nId", MVEH_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMVehiculo_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MVehiculo table by a foreign key.
		/// </summary>
		public void DeleteAllByMVEH_nIdMModelo(int MVEH_nIdMModelo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MVEH_nIdMModelo", MVEH_nIdMModelo)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMVehiculoDeleteAllByMVEH_nIdMModelo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MVehiculo table by a foreign key.
		/// </summary>
		public void DeleteAllByMVEH_nIdMProveedor(int MVEH_nIdMProveedor)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MVEH_nIdMProveedor", MVEH_nIdMProveedor)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMVehiculoDeleteAllByMVEH_nIdMProveedor", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MVehiculo table by a foreign key.
		/// </summary>
		public void DeleteAllByMVEH_nUsrReg(int MVEH_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MVEH_nUsrReg", MVEH_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMVehiculoDeleteAllByMVEH_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MVehiculo table by a foreign key.
		/// </summary>
		public void DeleteAllByMVEH_nUsrMod(int MVEH_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MVEH_nUsrMod", MVEH_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMVehiculoDeleteAllByMVEH_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MVehiculo por su primary key.
		/// </summary>
		public ENT_MVehiculo Select(int MVEH_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MVEH_nId", MVEH_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MVehiculo objMVehiculo = new ENT_MVehiculo();
			try{
					 objMVehiculo = GetEntity<ENT_MVehiculo>("spMVehiculo_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMVehiculo;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MVehiculo.
		/// </summary>
		public List<ENT_MVehiculo> SelectAll()
		{

			try{
				List<ENT_MVehiculo> x_oENT_MVehiculoList = new List<ENT_MVehiculo>();

				x_oENT_MVehiculoList = GetList<ENT_MVehiculo>("spMVehiculo_SelectAll");
				return x_oENT_MVehiculoList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla MVehiculo por un foreign key.
		/// </summary>
		public List<ENT_MVehiculo> SelectAllByMVEH_nIdMModelo(int MVEH_nIdMModelo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MVEH_nIdMModelo", MVEH_nIdMModelo)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MVehiculo> x_oENT_MVehiculoList = new List<ENT_MVehiculo>();

			try{
					x_oENT_MVehiculoList = GetList<ENT_MVehiculo>("spMVehiculoSelectAllByMVEH_nIdMModelo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MVehiculoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MVehiculo por un foreign key.
		/// </summary>
		public List<ENT_MVehiculo> SelectAllByMVEH_nIdMProveedor(int MVEH_nIdMProveedor)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MVEH_nIdMProveedor", MVEH_nIdMProveedor)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MVehiculo> x_oENT_MVehiculoList = new List<ENT_MVehiculo>();

			try{
					x_oENT_MVehiculoList = GetList<ENT_MVehiculo>("spMVehiculoSelectAllByMVEH_nIdMProveedor", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MVehiculoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MVehiculo por un foreign key.
		/// </summary>
		public List<ENT_MVehiculo> SelectAllByMVEH_nUsrReg(int MVEH_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MVEH_nUsrReg", MVEH_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MVehiculo> x_oENT_MVehiculoList = new List<ENT_MVehiculo>();

			try{
					x_oENT_MVehiculoList = GetList<ENT_MVehiculo>("spMVehiculoSelectAllByMVEH_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MVehiculoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MVehiculo por un foreign key.
		/// </summary>
		public List<ENT_MVehiculo> SelectAllByMVEH_nUsrMod(int MVEH_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MVEH_nUsrMod", MVEH_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MVehiculo> x_oENT_MVehiculoList = new List<ENT_MVehiculo>();

			try{
					x_oENT_MVehiculoList = GetList<ENT_MVehiculo>("spMVehiculoSelectAllByMVEH_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MVehiculoList;
		}


		#endregion
	}
}
