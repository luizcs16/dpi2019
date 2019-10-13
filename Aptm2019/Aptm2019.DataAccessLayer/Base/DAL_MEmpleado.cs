using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_MEmpleado : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MEmpleado.
		/// </summary>
		public void Insert(ENT_MEmpleado x_oENT_MEmpleado)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MEMP_cNombre", x_oENT_MEmpleado.MEMP_cNombre),
					new SqlParameter("@MEMP_cApePaterno", x_oENT_MEmpleado.MEMP_cApePaterno),
					new SqlParameter("@MEMP_cApeMaterno", x_oENT_MEmpleado.MEMP_cApeMaterno),
					new SqlParameter("@MEMP_nTipoDoc", x_oENT_MEmpleado.MEMP_nTipoDoc),
					new SqlParameter("@MEMP_nDocumento", x_oENT_MEmpleado.MEMP_nDocumento),
					new SqlParameter("@MEMP_cDireccion", x_oENT_MEmpleado.MEMP_cDireccion),
					new SqlParameter("@MEMP_cTelefono", x_oENT_MEmpleado.MEMP_cTelefono),
					new SqlParameter("@MEMP_nIdMUsuario", x_oENT_MEmpleado.MEMP_nIdMUsuario),
					new SqlParameter("@MEMP_lActivo", x_oENT_MEmpleado.MEMP_lActivo),
					new SqlParameter("@MEMP_nUsrReg", x_oENT_MEmpleado.MEMP_nUsrReg),
					new SqlParameter("@MEMP_dFechReg", x_oENT_MEmpleado.MEMP_dFechReg),
					new SqlParameter("@MEMP_nUsrMod", x_oENT_MEmpleado.MEMP_nUsrMod),
					new SqlParameter("@MEMP_dFechMod", x_oENT_MEmpleado.MEMP_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MEmpleado.MEMP_nId = (int)ejecutarScalar("spMEmpleado_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MEmpleado.
		/// </summary>
		public void Update(ENT_MEmpleado x_oENT_MEmpleado)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MEMP_nId", x_oENT_MEmpleado.MEMP_nId),
					new SqlParameter("@MEMP_cNombre", x_oENT_MEmpleado.MEMP_cNombre),
					new SqlParameter("@MEMP_cApePaterno", x_oENT_MEmpleado.MEMP_cApePaterno),
					new SqlParameter("@MEMP_cApeMaterno", x_oENT_MEmpleado.MEMP_cApeMaterno),
					new SqlParameter("@MEMP_nTipoDoc", x_oENT_MEmpleado.MEMP_nTipoDoc),
					new SqlParameter("@MEMP_nDocumento", x_oENT_MEmpleado.MEMP_nDocumento),
					new SqlParameter("@MEMP_cDireccion", x_oENT_MEmpleado.MEMP_cDireccion),
					new SqlParameter("@MEMP_cTelefono", x_oENT_MEmpleado.MEMP_cTelefono),
					new SqlParameter("@MEMP_nIdMUsuario", x_oENT_MEmpleado.MEMP_nIdMUsuario),
					new SqlParameter("@MEMP_lActivo", x_oENT_MEmpleado.MEMP_lActivo),
					new SqlParameter("@MEMP_nUsrReg", x_oENT_MEmpleado.MEMP_nUsrReg),
					new SqlParameter("@MEMP_dFechReg", x_oENT_MEmpleado.MEMP_dFechReg),
					new SqlParameter("@MEMP_nUsrMod", x_oENT_MEmpleado.MEMP_nUsrMod),
					new SqlParameter("@MEMP_dFechMod", x_oENT_MEmpleado.MEMP_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMEmpleado_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MEmpleado por su primary key.
		/// </summary>
		public void Delete(int MEMP_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MEMP_nId", MEMP_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMEmpleado_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MEmpleado table by a foreign key.
		/// </summary>
		public void DeleteAllByMEMP_nTipoDoc(int MEMP_nTipoDoc)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MEMP_nTipoDoc", MEMP_nTipoDoc)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMEmpleadoDeleteAllByMEMP_nTipoDoc", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MEmpleado table by a foreign key.
		/// </summary>
		public void DeleteAllByMEMP_nIdMUsuario(int MEMP_nIdMUsuario)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MEMP_nIdMUsuario", MEMP_nIdMUsuario)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMEmpleadoDeleteAllByMEMP_nIdMUsuario", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MEmpleado table by a foreign key.
		/// </summary>
		public void DeleteAllByMEMP_nUsrReg(int MEMP_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MEMP_nUsrReg", MEMP_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMEmpleadoDeleteAllByMEMP_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MEmpleado table by a foreign key.
		/// </summary>
		public void DeleteAllByMEMP_nUsrMod(int MEMP_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MEMP_nUsrMod", MEMP_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMEmpleadoDeleteAllByMEMP_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MEmpleado por su primary key.
		/// </summary>
		public ENT_MEmpleado Select(int MEMP_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MEMP_nId", MEMP_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MEmpleado objMEmpleado = new ENT_MEmpleado();
			try{
					 objMEmpleado = GetEntity<ENT_MEmpleado>("spMEmpleado_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMEmpleado;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MEmpleado.
		/// </summary>
		public List<ENT_MEmpleado> SelectAll()
		{

			try{
				List<ENT_MEmpleado> x_oENT_MEmpleadoList = new List<ENT_MEmpleado>();

				x_oENT_MEmpleadoList = GetList<ENT_MEmpleado>("spMEmpleado_SelectAll");
				return x_oENT_MEmpleadoList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla MEmpleado por un foreign key.
		/// </summary>
		public List<ENT_MEmpleado> SelectAllByMEMP_nTipoDoc(int MEMP_nTipoDoc)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MEMP_nTipoDoc", MEMP_nTipoDoc)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MEmpleado> x_oENT_MEmpleadoList = new List<ENT_MEmpleado>();

			try{
					x_oENT_MEmpleadoList = GetList<ENT_MEmpleado>("spMEmpleadoSelectAllByMEMP_nTipoDoc", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MEmpleadoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MEmpleado por un foreign key.
		/// </summary>
		public List<ENT_MEmpleado> SelectAllByMEMP_nIdMUsuario(int MEMP_nIdMUsuario)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MEMP_nIdMUsuario", MEMP_nIdMUsuario)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MEmpleado> x_oENT_MEmpleadoList = new List<ENT_MEmpleado>();

			try{
					x_oENT_MEmpleadoList = GetList<ENT_MEmpleado>("spMEmpleadoSelectAllByMEMP_nIdMUsuario", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MEmpleadoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MEmpleado por un foreign key.
		/// </summary>
		public List<ENT_MEmpleado> SelectAllByMEMP_nUsrReg(int MEMP_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MEMP_nUsrReg", MEMP_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MEmpleado> x_oENT_MEmpleadoList = new List<ENT_MEmpleado>();

			try{
					x_oENT_MEmpleadoList = GetList<ENT_MEmpleado>("spMEmpleadoSelectAllByMEMP_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MEmpleadoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MEmpleado por un foreign key.
		/// </summary>
		public List<ENT_MEmpleado> SelectAllByMEMP_nUsrMod(int MEMP_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MEMP_nUsrMod", MEMP_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MEmpleado> x_oENT_MEmpleadoList = new List<ENT_MEmpleado>();

			try{
					x_oENT_MEmpleadoList = GetList<ENT_MEmpleado>("spMEmpleadoSelectAllByMEMP_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MEmpleadoList;
		}


		#endregion
	}
}
