using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_MRepartoMarker : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MRepartoMarker.
		/// </summary>
		public void Insert(ENT_MRepartoMarker x_oENT_MRepartoMarker)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPMK_nIdMReparto", x_oENT_MRepartoMarker.MRPMK_nIdMReparto),
					new SqlParameter("@MRPMK_nLat", x_oENT_MRepartoMarker.MRPMK_nLat),
					new SqlParameter("@MRPMK_nLong", x_oENT_MRepartoMarker.MRPMK_nLong),
					new SqlParameter("@MRPMK_cDireccion", x_oENT_MRepartoMarker.MRPMK_cDireccion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MRepartoMarker.MRPMK_nId = (int)ejecutarScalar("spMRepartoMarker_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MRepartoMarker.
		/// </summary>
		public void Update(ENT_MRepartoMarker x_oENT_MRepartoMarker)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPMK_nId", x_oENT_MRepartoMarker.MRPMK_nId),
					new SqlParameter("@MRPMK_nIdMReparto", x_oENT_MRepartoMarker.MRPMK_nIdMReparto),
					new SqlParameter("@MRPMK_nLat", x_oENT_MRepartoMarker.MRPMK_nLat),
					new SqlParameter("@MRPMK_nLong", x_oENT_MRepartoMarker.MRPMK_nLong),
					new SqlParameter("@MRPMK_cDireccion", x_oENT_MRepartoMarker.MRPMK_cDireccion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoMarker_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MRepartoMarker por su primary key.
		/// </summary>
		public void Delete(int MRPMK_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPMK_nId", MRPMK_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoMarker_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MRepartoMarker table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPMK_nIdMReparto(int MRPMK_nIdMReparto)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPMK_nIdMReparto", MRPMK_nIdMReparto)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoMarkerDeleteAllByMRPMK_nIdMReparto", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MRepartoMarker por su primary key.
		/// </summary>
		public ENT_MRepartoMarker Select(int MRPMK_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPMK_nId", MRPMK_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MRepartoMarker objMRepartoMarker = new ENT_MRepartoMarker();
			try{
					 objMRepartoMarker = GetEntity<ENT_MRepartoMarker>("spMRepartoMarker_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMRepartoMarker;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MRepartoMarker.
		/// </summary>
		public List<ENT_MRepartoMarker> SelectAll()
		{

			try{
				List<ENT_MRepartoMarker> x_oENT_MRepartoMarkerList = new List<ENT_MRepartoMarker>();

				x_oENT_MRepartoMarkerList = GetList<ENT_MRepartoMarker>("spMRepartoMarker_SelectAll");
				return x_oENT_MRepartoMarkerList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla MRepartoMarker por un foreign key.
		/// </summary>
		public List<ENT_MRepartoMarker> SelectAllByMRPMK_nIdMReparto(int MRPMK_nIdMReparto)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MRPMK_nIdMReparto", MRPMK_nIdMReparto)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MRepartoMarker> x_oENT_MRepartoMarkerList = new List<ENT_MRepartoMarker>();

			try{
					x_oENT_MRepartoMarkerList = GetList<ENT_MRepartoMarker>("spMRepartoMarkerSelectAllByMRPMK_nIdMReparto", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MRepartoMarkerList;
		}


		#endregion
	}
}
