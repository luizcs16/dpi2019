using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Aptm2019Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_MMarca : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MMarca.
		/// </summary>
		public void Insert(ENT_MMarca x_oENT_MMarca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMRCA_cDescripcion", x_oENT_MMarca.MMRCA_cDescripcion),
					new SqlParameter("@MMRCA_nUsrReg", x_oENT_MMarca.MMRCA_nUsrReg),
					new SqlParameter("@MMRCA_dFechReg", x_oENT_MMarca.MMRCA_dFechReg),
					new SqlParameter("@MMRCA_nUsrMod", x_oENT_MMarca.MMRCA_nUsrMod),
					new SqlParameter("@MMRCA_dFechMod", x_oENT_MMarca.MMRCA_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MMarca.MMRCA_nId = (int)ejecutarScalar("spMMarca_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MMarca.
		/// </summary>
		public void Update(ENT_MMarca x_oENT_MMarca)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMRCA_nId", x_oENT_MMarca.MMRCA_nId),
					new SqlParameter("@MMRCA_cDescripcion", x_oENT_MMarca.MMRCA_cDescripcion),
					new SqlParameter("@MMRCA_nUsrReg", x_oENT_MMarca.MMRCA_nUsrReg),
					new SqlParameter("@MMRCA_dFechReg", x_oENT_MMarca.MMRCA_dFechReg),
					new SqlParameter("@MMRCA_nUsrMod", x_oENT_MMarca.MMRCA_nUsrMod),
					new SqlParameter("@MMRCA_dFechMod", x_oENT_MMarca.MMRCA_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMMarca_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MMarca por su primary key.
		/// </summary>
		public void Delete(int MMRCA_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMRCA_nId", MMRCA_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMMarca_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MMarca table by a foreign key.
		/// </summary>
		public void DeleteAllByMMRCA_nUsrReg(int MMRCA_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMRCA_nUsrReg", MMRCA_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMMarcaDeleteAllByMMRCA_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MMarca table by a foreign key.
		/// </summary>
		public void DeleteAllByMMRCA_nUsrMod(int MMRCA_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMRCA_nUsrMod", MMRCA_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMMarcaDeleteAllByMMRCA_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MMarca por su primary key.
		/// </summary>
		public ENT_MMarca Select(int MMRCA_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MMRCA_nId", MMRCA_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MMarca objMMarca = new ENT_MMarca();
			try{
					 objMMarca = GetEntity<ENT_MMarca>("spMMarca_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMMarca;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MMarca.
		/// </summary>
		public List<ENT_MMarca> SelectAll()
		{

			try{
				List<ENT_MMarca> x_oENT_MMarcaList = new List<ENT_MMarca>();

				x_oENT_MMarcaList = GetList<ENT_MMarca>("spMMarca_SelectAll");
				return x_oENT_MMarcaList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla MMarca por un foreign key.
		/// </summary>
		public List<ENT_MMarca> SelectAllByMMRCA_nUsrReg(int MMRCA_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MMRCA_nUsrReg", MMRCA_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MMarca> x_oENT_MMarcaList = new List<ENT_MMarca>();

			try{
					x_oENT_MMarcaList = GetList<ENT_MMarca>("spMMarcaSelectAllByMMRCA_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MMarcaList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MMarca por un foreign key.
		/// </summary>
		public List<ENT_MMarca> SelectAllByMMRCA_nUsrMod(int MMRCA_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MMRCA_nUsrMod", MMRCA_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MMarca> x_oENT_MMarcaList = new List<ENT_MMarca>();

			try{
					x_oENT_MMarcaList = GetList<ENT_MMarca>("spMMarcaSelectAllByMMRCA_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MMarcaList;
		}


		#endregion
	}
}
