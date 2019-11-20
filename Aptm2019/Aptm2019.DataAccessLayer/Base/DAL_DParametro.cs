using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Aptm2019Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_DParametro : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla DParametro.
		/// </summary>
		public void Insert(ENT_DParametro x_oENT_DParametro)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DPAR_nIdMParametro", x_oENT_DParametro.DPAR_nIdMParametro),
					new SqlParameter("@DPAR_cDescripcion", x_oENT_DParametro.DPAR_cDescripcion),
					new SqlParameter("@DPAR_cValor", x_oENT_DParametro.DPAR_cValor),
					new SqlParameter("@DPAR_lActivo", x_oENT_DParametro.DPAR_lActivo),
					new SqlParameter("@DPAR_nUsrReg", x_oENT_DParametro.DPAR_nUsrReg),
					new SqlParameter("@DPAR_dFechReg", x_oENT_DParametro.DPAR_dFechReg),
					new SqlParameter("@DPAR_nUsrMod", x_oENT_DParametro.DPAR_nUsrMod),
					new SqlParameter("@DPAR_dFechMod", x_oENT_DParametro.DPAR_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_DParametro.DPAR_nId = (int)ejecutarScalar("spDParametro_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla DParametro.
		/// </summary>
		public void Update(ENT_DParametro x_oENT_DParametro)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DPAR_nId", x_oENT_DParametro.DPAR_nId),
					new SqlParameter("@DPAR_nIdMParametro", x_oENT_DParametro.DPAR_nIdMParametro),
					new SqlParameter("@DPAR_cDescripcion", x_oENT_DParametro.DPAR_cDescripcion),
					new SqlParameter("@DPAR_cValor", x_oENT_DParametro.DPAR_cValor),
					new SqlParameter("@DPAR_lActivo", x_oENT_DParametro.DPAR_lActivo),
					new SqlParameter("@DPAR_nUsrReg", x_oENT_DParametro.DPAR_nUsrReg),
					new SqlParameter("@DPAR_dFechReg", x_oENT_DParametro.DPAR_dFechReg),
					new SqlParameter("@DPAR_nUsrMod", x_oENT_DParametro.DPAR_nUsrMod),
					new SqlParameter("@DPAR_dFechMod", x_oENT_DParametro.DPAR_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spDParametro_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla DParametro por su primary key.
		/// </summary>
		public void Delete(int DPAR_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DPAR_nId", DPAR_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spDParametro_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the DParametro table by a foreign key.
		/// </summary>
		public void DeleteAllByDPAR_nIdMParametro(int DPAR_nIdMParametro)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DPAR_nIdMParametro", DPAR_nIdMParametro)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spDParametroDeleteAllByDPAR_nIdMParametro", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the DParametro table by a foreign key.
		/// </summary>
		public void DeleteAllByDPAR_nUsrReg(int DPAR_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DPAR_nUsrReg", DPAR_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spDParametroDeleteAllByDPAR_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the DParametro table by a foreign key.
		/// </summary>
		public void DeleteAllByDPAR_nUsrMod(int DPAR_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DPAR_nUsrMod", DPAR_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spDParametroDeleteAllByDPAR_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla DParametro por su primary key.
		/// </summary>
		public ENT_DParametro Select(int DPAR_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DPAR_nId", DPAR_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_DParametro objDParametro = new ENT_DParametro();
			try{
					 objDParametro = GetEntity<ENT_DParametro>("spDParametro_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objDParametro;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla DParametro.
		/// </summary>
		public List<ENT_DParametro> SelectAll()
		{

			try{
				List<ENT_DParametro> x_oENT_DParametroList = new List<ENT_DParametro>();

				x_oENT_DParametroList = GetList<ENT_DParametro>("spDParametro_SelectAll");
				return x_oENT_DParametroList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla DParametro por un foreign key.
		/// </summary>
		public List<ENT_DParametro> SelectAllByDPAR_nIdMParametro(int DPAR_nIdMParametro)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@DPAR_nIdMParametro", DPAR_nIdMParametro)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_DParametro> x_oENT_DParametroList = new List<ENT_DParametro>();

			try{
					x_oENT_DParametroList = GetList<ENT_DParametro>("spDParametroSelectAllByDPAR_nIdMParametro", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_DParametroList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla DParametro por un foreign key.
		/// </summary>
		public List<ENT_DParametro> SelectAllByDPAR_nUsrReg(int DPAR_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@DPAR_nUsrReg", DPAR_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_DParametro> x_oENT_DParametroList = new List<ENT_DParametro>();

			try{
					x_oENT_DParametroList = GetList<ENT_DParametro>("spDParametroSelectAllByDPAR_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_DParametroList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla DParametro por un foreign key.
		/// </summary>
		public List<ENT_DParametro> SelectAllByDPAR_nUsrMod(int DPAR_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@DPAR_nUsrMod", DPAR_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_DParametro> x_oENT_DParametroList = new List<ENT_DParametro>();

			try{
					x_oENT_DParametroList = GetList<ENT_DParametro>("spDParametroSelectAllByDPAR_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_DParametroList;
		}


		#endregion
	}
}
