using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Aptm2019Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_MRepartoItem : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MRepartoItem.
		/// </summary>
		public void Insert(ENT_MRepartoItem x_oENT_MRepartoItem)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPITM_nTipoComprobante", x_oENT_MRepartoItem.MRPITM_nTipoComprobante),
					new SqlParameter("@MRPITM_cComprobante", x_oENT_MRepartoItem.MRPITM_cComprobante),
					new SqlParameter("@MRPITM_nIdCliente", x_oENT_MRepartoItem.MRPITM_nIdCliente),
					new SqlParameter("@MRPITM_nLat", x_oENT_MRepartoItem.MRPITM_nLat),
					new SqlParameter("@MRPITM_nLong", x_oENT_MRepartoItem.MRPITM_nLong),
					new SqlParameter("@MRPITM_cDireccion", x_oENT_MRepartoItem.MRPITM_cDireccion),
					new SqlParameter("@MRPITM_nAncho", x_oENT_MRepartoItem.MRPITM_nAncho),
					new SqlParameter("@MRPITM_nLargo", x_oENT_MRepartoItem.MRPITM_nLargo),
					new SqlParameter("@MRPITM_nAlto", x_oENT_MRepartoItem.MRPITM_nAlto),
					new SqlParameter("@MRPITM_nEstado", x_oENT_MRepartoItem.MRPITM_nEstado),
					new SqlParameter("@MRPITM_lActivo", x_oENT_MRepartoItem.MRPITM_lActivo),
					new SqlParameter("@MRPITM_nUsrReg", x_oENT_MRepartoItem.MRPITM_nUsrReg),
					new SqlParameter("@MRPITM_dFechReg", x_oENT_MRepartoItem.MRPITM_dFechReg),
					new SqlParameter("@MRPITM_nUsrMod", x_oENT_MRepartoItem.MRPITM_nUsrMod),
					new SqlParameter("@MRPITM_dFechMod", x_oENT_MRepartoItem.MRPITM_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MRepartoItem.MRPITM_nId = (int)ejecutarScalar("spMRepartoItem_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MRepartoItem.
		/// </summary>
		public void Update(ENT_MRepartoItem x_oENT_MRepartoItem)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPITM_nId", x_oENT_MRepartoItem.MRPITM_nId),
					new SqlParameter("@MRPITM_nTipoComprobante", x_oENT_MRepartoItem.MRPITM_nTipoComprobante),
					new SqlParameter("@MRPITM_cComprobante", x_oENT_MRepartoItem.MRPITM_cComprobante),
					new SqlParameter("@MRPITM_nIdCliente", x_oENT_MRepartoItem.MRPITM_nIdCliente),
					new SqlParameter("@MRPITM_nLat", x_oENT_MRepartoItem.MRPITM_nLat),
					new SqlParameter("@MRPITM_nLong", x_oENT_MRepartoItem.MRPITM_nLong),
					new SqlParameter("@MRPITM_cDireccion", x_oENT_MRepartoItem.MRPITM_cDireccion),
					new SqlParameter("@MRPITM_nAncho", x_oENT_MRepartoItem.MRPITM_nAncho),
					new SqlParameter("@MRPITM_nLargo", x_oENT_MRepartoItem.MRPITM_nLargo),
					new SqlParameter("@MRPITM_nAlto", x_oENT_MRepartoItem.MRPITM_nAlto),
					new SqlParameter("@MRPITM_nEstado", x_oENT_MRepartoItem.MRPITM_nEstado),
					new SqlParameter("@MRPITM_lActivo", x_oENT_MRepartoItem.MRPITM_lActivo),
					new SqlParameter("@MRPITM_nUsrReg", x_oENT_MRepartoItem.MRPITM_nUsrReg),
					new SqlParameter("@MRPITM_dFechReg", x_oENT_MRepartoItem.MRPITM_dFechReg),
					new SqlParameter("@MRPITM_nUsrMod", x_oENT_MRepartoItem.MRPITM_nUsrMod),
					new SqlParameter("@MRPITM_dFechMod", x_oENT_MRepartoItem.MRPITM_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoItem_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MRepartoItem por su primary key.
		/// </summary>
		public void Delete(int MRPITM_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPITM_nId", MRPITM_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoItem_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MRepartoItem table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPITM_nTipoComprobante(int MRPITM_nTipoComprobante)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPITM_nTipoComprobante", MRPITM_nTipoComprobante)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoItemDeleteAllByMRPITM_nTipoComprobante", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MRepartoItem table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPITM_nEstado(int MRPITM_nEstado)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPITM_nEstado", MRPITM_nEstado)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoItemDeleteAllByMRPITM_nEstado", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MRepartoItem table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPITM_nIdCliente(int MRPITM_nIdCliente)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPITM_nIdCliente", MRPITM_nIdCliente)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoItemDeleteAllByMRPITM_nIdCliente", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MRepartoItem table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPITM_nUsrReg(int MRPITM_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPITM_nUsrReg", MRPITM_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoItemDeleteAllByMRPITM_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MRepartoItem table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPITM_nUsrMod(int MRPITM_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPITM_nUsrMod", MRPITM_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoItemDeleteAllByMRPITM_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MRepartoItem por su primary key.
		/// </summary>
		public ENT_MRepartoItem Select(int MRPITM_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPITM_nId", MRPITM_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MRepartoItem objMRepartoItem = new ENT_MRepartoItem();
			try{
					 objMRepartoItem = GetEntity<ENT_MRepartoItem>("spMRepartoItem_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMRepartoItem;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MRepartoItem.
		/// </summary>
		public List<ENT_MRepartoItem> SelectAll()
		{

			try{
				List<ENT_MRepartoItem> x_oENT_MRepartoItemList = new List<ENT_MRepartoItem>();

				x_oENT_MRepartoItemList = GetList<ENT_MRepartoItem>("spMRepartoItem_SelectAll");
				return x_oENT_MRepartoItemList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla MRepartoItem por un foreign key.
		/// </summary>
		public List<ENT_MRepartoItem> SelectAllByMRPITM_nTipoComprobante(int MRPITM_nTipoComprobante)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MRPITM_nTipoComprobante", MRPITM_nTipoComprobante)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MRepartoItem> x_oENT_MRepartoItemList = new List<ENT_MRepartoItem>();

			try{
					x_oENT_MRepartoItemList = GetList<ENT_MRepartoItem>("spMRepartoItemSelectAllByMRPITM_nTipoComprobante", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MRepartoItemList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MRepartoItem por un foreign key.
		/// </summary>
		public List<ENT_MRepartoItem> SelectAllByMRPITM_nEstado(int MRPITM_nEstado)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MRPITM_nEstado", MRPITM_nEstado)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MRepartoItem> x_oENT_MRepartoItemList = new List<ENT_MRepartoItem>();

			try{
					x_oENT_MRepartoItemList = GetList<ENT_MRepartoItem>("spMRepartoItemSelectAllByMRPITM_nEstado", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MRepartoItemList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MRepartoItem por un foreign key.
		/// </summary>
		public List<ENT_MRepartoItem> SelectAllByMRPITM_nIdCliente(int MRPITM_nIdCliente)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MRPITM_nIdCliente", MRPITM_nIdCliente)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MRepartoItem> x_oENT_MRepartoItemList = new List<ENT_MRepartoItem>();

			try{
					x_oENT_MRepartoItemList = GetList<ENT_MRepartoItem>("spMRepartoItemSelectAllByMRPITM_nIdCliente", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MRepartoItemList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MRepartoItem por un foreign key.
		/// </summary>
		public List<ENT_MRepartoItem> SelectAllByMRPITM_nUsrReg(int MRPITM_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MRPITM_nUsrReg", MRPITM_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MRepartoItem> x_oENT_MRepartoItemList = new List<ENT_MRepartoItem>();

			try{
					x_oENT_MRepartoItemList = GetList<ENT_MRepartoItem>("spMRepartoItemSelectAllByMRPITM_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MRepartoItemList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MRepartoItem por un foreign key.
		/// </summary>
		public List<ENT_MRepartoItem> SelectAllByMRPITM_nUsrMod(int MRPITM_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MRPITM_nUsrMod", MRPITM_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MRepartoItem> x_oENT_MRepartoItemList = new List<ENT_MRepartoItem>();

			try{
					x_oENT_MRepartoItemList = GetList<ENT_MRepartoItem>("spMRepartoItemSelectAllByMRPITM_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MRepartoItemList;
		}


		#endregion
	}
}
