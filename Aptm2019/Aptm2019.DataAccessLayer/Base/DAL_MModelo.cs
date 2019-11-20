using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Aptm2019Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_MModelo : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MModelo.
		/// </summary>
		public void Insert(ENT_MModelo x_oENT_MModelo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMDLO_nIdMMarca", x_oENT_MModelo.MMDLO_nIdMMarca),
					new SqlParameter("@MMDLO_cDescripcion", x_oENT_MModelo.MMDLO_cDescripcion),
					new SqlParameter("@MMDLO_nUsrReg", x_oENT_MModelo.MMDLO_nUsrReg),
					new SqlParameter("@MMDLO_dFechReg", x_oENT_MModelo.MMDLO_dFechReg),
					new SqlParameter("@MMDLO_nUsrMod", x_oENT_MModelo.MMDLO_nUsrMod),
					new SqlParameter("@MMDLO_dFechMod", x_oENT_MModelo.MMDLO_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MModelo.MMDLO_nId = (int)ejecutarScalar("spMModelo_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MModelo.
		/// </summary>
		public void Update(ENT_MModelo x_oENT_MModelo)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMDLO_nId", x_oENT_MModelo.MMDLO_nId),
					new SqlParameter("@MMDLO_nIdMMarca", x_oENT_MModelo.MMDLO_nIdMMarca),
					new SqlParameter("@MMDLO_cDescripcion", x_oENT_MModelo.MMDLO_cDescripcion),
					new SqlParameter("@MMDLO_nUsrReg", x_oENT_MModelo.MMDLO_nUsrReg),
					new SqlParameter("@MMDLO_dFechReg", x_oENT_MModelo.MMDLO_dFechReg),
					new SqlParameter("@MMDLO_nUsrMod", x_oENT_MModelo.MMDLO_nUsrMod),
					new SqlParameter("@MMDLO_dFechMod", x_oENT_MModelo.MMDLO_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMModelo_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MModelo por su primary key.
		/// </summary>
		public void Delete(int MMDLO_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMDLO_nId", MMDLO_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMModelo_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MModelo table by a foreign key.
		/// </summary>
		public void DeleteAllByMMDLO_nIdMMarca(int MMDLO_nIdMMarca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMDLO_nIdMMarca", MMDLO_nIdMMarca)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMModeloDeleteAllByMMDLO_nIdMMarca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MModelo table by a foreign key.
		/// </summary>
		public void DeleteAllByMMDLO_nUsrReg(int MMDLO_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMDLO_nUsrReg", MMDLO_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMModeloDeleteAllByMMDLO_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MModelo table by a foreign key.
		/// </summary>
		public void DeleteAllByMMDLO_nUsrMod(int MMDLO_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMDLO_nUsrMod", MMDLO_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMModeloDeleteAllByMMDLO_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MModelo por su primary key.
		/// </summary>
		public ENT_MModelo Select(int MMDLO_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMDLO_nId", MMDLO_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MModelo objMModelo = new ENT_MModelo();
			try{
					 objMModelo = GetEntity<ENT_MModelo>("spMModelo_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMModelo;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MModelo.
		/// </summary>
		public List<ENT_MModelo> SelectAll()
		{

			try{
				List<ENT_MModelo> x_oENT_MModeloList = new List<ENT_MModelo>();

				x_oENT_MModeloList = GetList<ENT_MModelo>("spMModelo_SelectAll");
				return x_oENT_MModeloList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla MModelo por un foreign key.
		/// </summary>
		public List<ENT_MModelo> SelectAllByMMDLO_nIdMMarca(int MMDLO_nIdMMarca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MMDLO_nIdMMarca", MMDLO_nIdMMarca)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MModelo> x_oENT_MModeloList = new List<ENT_MModelo>();

			try{
					x_oENT_MModeloList = GetList<ENT_MModelo>("spMModeloSelectAllByMMDLO_nIdMMarca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MModeloList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MModelo por un foreign key.
		/// </summary>
		public List<ENT_MModelo> SelectAllByMMDLO_nUsrReg(int MMDLO_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MMDLO_nUsrReg", MMDLO_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MModelo> x_oENT_MModeloList = new List<ENT_MModelo>();

			try{
					x_oENT_MModeloList = GetList<ENT_MModelo>("spMModeloSelectAllByMMDLO_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MModeloList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MModelo por un foreign key.
		/// </summary>
		public List<ENT_MModelo> SelectAllByMMDLO_nUsrMod(int MMDLO_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MMDLO_nUsrMod", MMDLO_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MModelo> x_oENT_MModeloList = new List<ENT_MModelo>();

			try{
					x_oENT_MModeloList = GetList<ENT_MModelo>("spMModeloSelectAllByMMDLO_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MModeloList;
		}


		#endregion
	}
}
