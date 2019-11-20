using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Aptm2019Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_MReparto : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MReparto.
		/// </summary>
		public void Insert(ENT_MReparto x_oENT_MReparto)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPT_nIdServicioReparto", x_oENT_MReparto.MRPT_nIdServicioReparto),
					new SqlParameter("@MRPT_dHInicio", x_oENT_MReparto.MRPT_dHInicio),
					new SqlParameter("@MRPT_dHFin", x_oENT_MReparto.MRPT_dHFin),
					new SqlParameter("@MRPT_lActivo", x_oENT_MReparto.MRPT_lActivo),
					new SqlParameter("@MRPT_nUsrReg", x_oENT_MReparto.MRPT_nUsrReg),
					new SqlParameter("@MRPT_dFechReg", x_oENT_MReparto.MRPT_dFechReg),
					new SqlParameter("@MRPT_nUsrMod", x_oENT_MReparto.MRPT_nUsrMod),
					new SqlParameter("@MRPT_dFechMod", x_oENT_MReparto.MRPT_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MReparto.MRPT_nId = (int)ejecutarScalar("spMReparto_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MReparto.
		/// </summary>
		public void Update(ENT_MReparto x_oENT_MReparto)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPT_nId", x_oENT_MReparto.MRPT_nId),
					new SqlParameter("@MRPT_nIdServicioReparto", x_oENT_MReparto.MRPT_nIdServicioReparto),
					new SqlParameter("@MRPT_dHInicio", x_oENT_MReparto.MRPT_dHInicio),
					new SqlParameter("@MRPT_dHFin", x_oENT_MReparto.MRPT_dHFin),
					new SqlParameter("@MRPT_lActivo", x_oENT_MReparto.MRPT_lActivo),
					new SqlParameter("@MRPT_nUsrReg", x_oENT_MReparto.MRPT_nUsrReg),
					new SqlParameter("@MRPT_dFechReg", x_oENT_MReparto.MRPT_dFechReg),
					new SqlParameter("@MRPT_nUsrMod", x_oENT_MReparto.MRPT_nUsrMod),
					new SqlParameter("@MRPT_dFechMod", x_oENT_MReparto.MRPT_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMReparto_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MReparto por su primary key.
		/// </summary>
		public void Delete(int MRPT_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPT_nId", MRPT_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMReparto_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPT_nIdServicioReparto(int MRPT_nIdServicioReparto)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPT_nIdServicioReparto", MRPT_nIdServicioReparto)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoDeleteAllByMRPT_nIdServicioReparto", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPT_nUsrReg(int MRPT_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPT_nUsrReg", MRPT_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoDeleteAllByMRPT_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MReparto table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPT_nUsrMod(int MRPT_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPT_nUsrMod", MRPT_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMRepartoDeleteAllByMRPT_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MReparto por su primary key.
		/// </summary>
		public ENT_MReparto Select(int MRPT_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MRPT_nId", MRPT_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MReparto objMReparto = new ENT_MReparto();
			try{
					 objMReparto = GetEntity<ENT_MReparto>("spMReparto_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMReparto;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MReparto.
		/// </summary>
		public List<ENT_MReparto> SelectAll()
		{

			try{
				List<ENT_MReparto> x_oENT_MRepartoList = new List<ENT_MReparto>();

				x_oENT_MRepartoList = GetList<ENT_MReparto>("spMReparto_SelectAll");
				return x_oENT_MRepartoList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla MReparto por un foreign key.
		/// </summary>
		public List<ENT_MReparto> SelectAllByMRPT_nIdServicioReparto(int MRPT_nIdServicioReparto)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MRPT_nIdServicioReparto", MRPT_nIdServicioReparto)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MReparto> x_oENT_MRepartoList = new List<ENT_MReparto>();

			try{
					x_oENT_MRepartoList = GetList<ENT_MReparto>("spMRepartoSelectAllByMRPT_nIdServicioReparto", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MRepartoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MReparto por un foreign key.
		/// </summary>
		public List<ENT_MReparto> SelectAllByMRPT_nUsrReg(int MRPT_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MRPT_nUsrReg", MRPT_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MReparto> x_oENT_MRepartoList = new List<ENT_MReparto>();

			try{
					x_oENT_MRepartoList = GetList<ENT_MReparto>("spMRepartoSelectAllByMRPT_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MRepartoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MReparto por un foreign key.
		/// </summary>
		public List<ENT_MReparto> SelectAllByMRPT_nUsrMod(int MRPT_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MRPT_nUsrMod", MRPT_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MReparto> x_oENT_MRepartoList = new List<ENT_MReparto>();

			try{
					x_oENT_MRepartoList = GetList<ENT_MReparto>("spMRepartoSelectAllByMRPT_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MRepartoList;
		}


		#endregion
	}
}
