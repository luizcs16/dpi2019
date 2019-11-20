using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Aptm2019Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_MParametro : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MParametro.
		/// </summary>
		public void Insert(ENT_MParametro x_oENT_MParametro)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPAR_cDescripcion", x_oENT_MParametro.MPAR_cDescripcion),
					new SqlParameter("@MPAR_nMasterId", x_oENT_MParametro.MPAR_nMasterId),
					new SqlParameter("@MPAR_lActivo", x_oENT_MParametro.MPAR_lActivo),
					new SqlParameter("@MPAR_nUsrReg", x_oENT_MParametro.MPAR_nUsrReg),
					new SqlParameter("@MPAR_dFechReg", x_oENT_MParametro.MPAR_dFechReg),
					new SqlParameter("@MPAR_nUsrMod", x_oENT_MParametro.MPAR_nUsrMod),
					new SqlParameter("@MPAR_dFechMod", x_oENT_MParametro.MPAR_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MParametro.MPAR_nId = (int)ejecutarScalar("spMParametro_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MParametro.
		/// </summary>
		public void Update(ENT_MParametro x_oENT_MParametro)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPAR_nId", x_oENT_MParametro.MPAR_nId),
					new SqlParameter("@MPAR_cDescripcion", x_oENT_MParametro.MPAR_cDescripcion),
					new SqlParameter("@MPAR_nMasterId", x_oENT_MParametro.MPAR_nMasterId),
					new SqlParameter("@MPAR_lActivo", x_oENT_MParametro.MPAR_lActivo),
					new SqlParameter("@MPAR_nUsrReg", x_oENT_MParametro.MPAR_nUsrReg),
					new SqlParameter("@MPAR_dFechReg", x_oENT_MParametro.MPAR_dFechReg),
					new SqlParameter("@MPAR_nUsrMod", x_oENT_MParametro.MPAR_nUsrMod),
					new SqlParameter("@MPAR_dFechMod", x_oENT_MParametro.MPAR_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMParametro_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MParametro por su primary key.
		/// </summary>
		public void Delete(int MPAR_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPAR_nId", MPAR_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMParametro_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MParametro table by a foreign key.
		/// </summary>
		public void DeleteAllByMPAR_nMasterId(int MPAR_nMasterId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPAR_nMasterId", MPAR_nMasterId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMParametroDeleteAllByMPAR_nMasterId", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MParametro table by a foreign key.
		/// </summary>
		public void DeleteAllByMPAR_nUsrReg(int MPAR_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPAR_nUsrReg", MPAR_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMParametroDeleteAllByMPAR_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MParametro table by a foreign key.
		/// </summary>
		public void DeleteAllByMPAR_nUsrMod(int MPAR_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPAR_nUsrMod", MPAR_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMParametroDeleteAllByMPAR_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MParametro por su primary key.
		/// </summary>
		public ENT_MParametro Select(int MPAR_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPAR_nId", MPAR_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MParametro objMParametro = new ENT_MParametro();
			try{
					 objMParametro = GetEntity<ENT_MParametro>("spMParametro_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMParametro;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MParametro.
		/// </summary>
		public List<ENT_MParametro> SelectAll()
		{

			try{
				List<ENT_MParametro> x_oENT_MParametroList = new List<ENT_MParametro>();

				x_oENT_MParametroList = GetList<ENT_MParametro>("spMParametro_SelectAll");
				return x_oENT_MParametroList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla MParametro por un foreign key.
		/// </summary>
		public List<ENT_MParametro> SelectAllByMPAR_nMasterId(int MPAR_nMasterId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MPAR_nMasterId", MPAR_nMasterId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MParametro> x_oENT_MParametroList = new List<ENT_MParametro>();

			try{
					x_oENT_MParametroList = GetList<ENT_MParametro>("spMParametroSelectAllByMPAR_nMasterId", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MParametroList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MParametro por un foreign key.
		/// </summary>
		public List<ENT_MParametro> SelectAllByMPAR_nUsrReg(int MPAR_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MPAR_nUsrReg", MPAR_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MParametro> x_oENT_MParametroList = new List<ENT_MParametro>();

			try{
					x_oENT_MParametroList = GetList<ENT_MParametro>("spMParametroSelectAllByMPAR_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MParametroList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MParametro por un foreign key.
		/// </summary>
		public List<ENT_MParametro> SelectAllByMPAR_nUsrMod(int MPAR_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MPAR_nUsrMod", MPAR_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MParametro> x_oENT_MParametroList = new List<ENT_MParametro>();

			try{
					x_oENT_MParametroList = GetList<ENT_MParametro>("spMParametroSelectAllByMPAR_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MParametroList;
		}


		#endregion
	}
}
