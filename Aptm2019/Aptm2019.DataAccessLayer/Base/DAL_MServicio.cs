using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_MServicio : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MServicio.
		/// </summary>
		public void Insert(ENT_MServicio x_oENT_MServicio)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSRV_nTipoSrv", x_oENT_MServicio.MSRV_nTipoSrv),
					new SqlParameter("@MSRV_dHInicio", x_oENT_MServicio.MSRV_dHInicio),
					new SqlParameter("@MSRV_dHFin", x_oENT_MServicio.MSRV_dHFin),
					new SqlParameter("@MSRV_lActivo", x_oENT_MServicio.MSRV_lActivo),
					new SqlParameter("@MSRV_nUsrReg", x_oENT_MServicio.MSRV_nUsrReg),
					new SqlParameter("@MSRV_dFechReg", x_oENT_MServicio.MSRV_dFechReg),
					new SqlParameter("@MSRV_nUsrMod", x_oENT_MServicio.MSRV_nUsrMod),
					new SqlParameter("@MSRV_dFechMod", x_oENT_MServicio.MSRV_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MServicio.MSRV_nId = (int)ejecutarScalar("spMServicio_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MServicio.
		/// </summary>
		public void Update(ENT_MServicio x_oENT_MServicio)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSRV_nId", x_oENT_MServicio.MSRV_nId),
					new SqlParameter("@MSRV_nTipoSrv", x_oENT_MServicio.MSRV_nTipoSrv),
					new SqlParameter("@MSRV_dHInicio", x_oENT_MServicio.MSRV_dHInicio),
					new SqlParameter("@MSRV_dHFin", x_oENT_MServicio.MSRV_dHFin),
					new SqlParameter("@MSRV_lActivo", x_oENT_MServicio.MSRV_lActivo),
					new SqlParameter("@MSRV_nUsrReg", x_oENT_MServicio.MSRV_nUsrReg),
					new SqlParameter("@MSRV_dFechReg", x_oENT_MServicio.MSRV_dFechReg),
					new SqlParameter("@MSRV_nUsrMod", x_oENT_MServicio.MSRV_nUsrMod),
					new SqlParameter("@MSRV_dFechMod", x_oENT_MServicio.MSRV_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMServicio_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MServicio por su primary key.
		/// </summary>
		public void Delete(int MSRV_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSRV_nId", MSRV_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMServicio_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MServicio table by a foreign key.
		/// </summary>
		public void DeleteAllByMSRV_nTipoSrv(int MSRV_nTipoSrv)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSRV_nTipoSrv", MSRV_nTipoSrv)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMServicioDeleteAllByMSRV_nTipoSrv", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MServicio table by a foreign key.
		/// </summary>
		public void DeleteAllByMSRV_nUsrReg(int MSRV_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSRV_nUsrReg", MSRV_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMServicioDeleteAllByMSRV_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MServicio table by a foreign key.
		/// </summary>
		public void DeleteAllByMSRV_nUsrMod(int MSRV_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSRV_nUsrMod", MSRV_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMServicioDeleteAllByMSRV_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MServicio por su primary key.
		/// </summary>
		public ENT_MServicio Select(int MSRV_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MSRV_nId", MSRV_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MServicio objMServicio = new ENT_MServicio();
			try{
					 objMServicio = GetEntity<ENT_MServicio>("spMServicio_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMServicio;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MServicio.
		/// </summary>
		public List<ENT_MServicio> SelectAll()
		{

			try{
				List<ENT_MServicio> x_oENT_MServicioList = new List<ENT_MServicio>();

				x_oENT_MServicioList = GetList<ENT_MServicio>("spMServicio_SelectAll");
				return x_oENT_MServicioList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicio por un foreign key.
		/// </summary>
		public List<ENT_MServicio> SelectAllByMSRV_nTipoSrv(int MSRV_nTipoSrv)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MSRV_nTipoSrv", MSRV_nTipoSrv)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MServicio> x_oENT_MServicioList = new List<ENT_MServicio>();

			try{
					x_oENT_MServicioList = GetList<ENT_MServicio>("spMServicioSelectAllByMSRV_nTipoSrv", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MServicioList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicio por un foreign key.
		/// </summary>
		public List<ENT_MServicio> SelectAllByMSRV_nUsrReg(int MSRV_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MSRV_nUsrReg", MSRV_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MServicio> x_oENT_MServicioList = new List<ENT_MServicio>();

			try{
					x_oENT_MServicioList = GetList<ENT_MServicio>("spMServicioSelectAllByMSRV_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MServicioList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicio por un foreign key.
		/// </summary>
		public List<ENT_MServicio> SelectAllByMSRV_nUsrMod(int MSRV_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MSRV_nUsrMod", MSRV_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MServicio> x_oENT_MServicioList = new List<ENT_MServicio>();

			try{
					x_oENT_MServicioList = GetList<ENT_MServicio>("spMServicioSelectAllByMSRV_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MServicioList;
		}


		#endregion
	}
}
