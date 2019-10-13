using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_MCliente : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MCliente.
		/// </summary>
		public void Insert(ENT_MCliente x_oENT_MCliente)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MCLI_cNombre", x_oENT_MCliente.MCLI_cNombre),
					new SqlParameter("@MCLI_cApePaterno", x_oENT_MCliente.MCLI_cApePaterno),
					new SqlParameter("@MCLI_cApeMaterno", x_oENT_MCliente.MCLI_cApeMaterno),
					new SqlParameter("@MCLI_nTipoDoc", x_oENT_MCliente.MCLI_nTipoDoc),
					new SqlParameter("@MCLI_cDocumento", x_oENT_MCliente.MCLI_cDocumento),
					new SqlParameter("@MCLI_lActivo", x_oENT_MCliente.MCLI_lActivo),
					new SqlParameter("@MCLI_nUsrReg", x_oENT_MCliente.MCLI_nUsrReg),
					new SqlParameter("@MCLI_dFechReg", x_oENT_MCliente.MCLI_dFechReg),
					new SqlParameter("@MCLI_nUsrMod", x_oENT_MCliente.MCLI_nUsrMod),
					new SqlParameter("@MCLI_dFechMod", x_oENT_MCliente.MCLI_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MCliente.MCLI_nId = (int)ejecutarScalar("spMCliente_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MCliente.
		/// </summary>
		public void Update(ENT_MCliente x_oENT_MCliente)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MCLI_nId", x_oENT_MCliente.MCLI_nId),
					new SqlParameter("@MCLI_cNombre", x_oENT_MCliente.MCLI_cNombre),
					new SqlParameter("@MCLI_cApePaterno", x_oENT_MCliente.MCLI_cApePaterno),
					new SqlParameter("@MCLI_cApeMaterno", x_oENT_MCliente.MCLI_cApeMaterno),
					new SqlParameter("@MCLI_nTipoDoc", x_oENT_MCliente.MCLI_nTipoDoc),
					new SqlParameter("@MCLI_cDocumento", x_oENT_MCliente.MCLI_cDocumento),
					new SqlParameter("@MCLI_lActivo", x_oENT_MCliente.MCLI_lActivo),
					new SqlParameter("@MCLI_nUsrReg", x_oENT_MCliente.MCLI_nUsrReg),
					new SqlParameter("@MCLI_dFechReg", x_oENT_MCliente.MCLI_dFechReg),
					new SqlParameter("@MCLI_nUsrMod", x_oENT_MCliente.MCLI_nUsrMod),
					new SqlParameter("@MCLI_dFechMod", x_oENT_MCliente.MCLI_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMCliente_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MCliente por su primary key.
		/// </summary>
		public void Delete(int MCLI_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MCLI_nId", MCLI_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMCliente_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MCliente table by a foreign key.
		/// </summary>
		public void DeleteAllByMCLI_nTipoDoc(int MCLI_nTipoDoc)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MCLI_nTipoDoc", MCLI_nTipoDoc)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMClienteDeleteAllByMCLI_nTipoDoc", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MCliente table by a foreign key.
		/// </summary>
		public void DeleteAllByMCLI_nUsrReg(int MCLI_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MCLI_nUsrReg", MCLI_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMClienteDeleteAllByMCLI_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MCliente table by a foreign key.
		/// </summary>
		public void DeleteAllByMCLI_nUsrMod(int MCLI_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MCLI_nUsrMod", MCLI_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMClienteDeleteAllByMCLI_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MCliente por su primary key.
		/// </summary>
		public ENT_MCliente Select(int MCLI_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MCLI_nId", MCLI_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MCliente objMCliente = new ENT_MCliente();
			try{
					 objMCliente = GetEntity<ENT_MCliente>("spMCliente_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMCliente;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MCliente.
		/// </summary>
		public List<ENT_MCliente> SelectAll()
		{

			try{
				List<ENT_MCliente> x_oENT_MClienteList = new List<ENT_MCliente>();

				x_oENT_MClienteList = GetList<ENT_MCliente>("spMCliente_SelectAll");
				return x_oENT_MClienteList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla MCliente por un foreign key.
		/// </summary>
		public List<ENT_MCliente> SelectAllByMCLI_nTipoDoc(int MCLI_nTipoDoc)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MCLI_nTipoDoc", MCLI_nTipoDoc)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MCliente> x_oENT_MClienteList = new List<ENT_MCliente>();

			try{
					x_oENT_MClienteList = GetList<ENT_MCliente>("spMClienteSelectAllByMCLI_nTipoDoc", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MClienteList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MCliente por un foreign key.
		/// </summary>
		public List<ENT_MCliente> SelectAllByMCLI_nUsrReg(int MCLI_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MCLI_nUsrReg", MCLI_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MCliente> x_oENT_MClienteList = new List<ENT_MCliente>();

			try{
					x_oENT_MClienteList = GetList<ENT_MCliente>("spMClienteSelectAllByMCLI_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MClienteList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MCliente por un foreign key.
		/// </summary>
		public List<ENT_MCliente> SelectAllByMCLI_nUsrMod(int MCLI_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MCLI_nUsrMod", MCLI_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MCliente> x_oENT_MClienteList = new List<ENT_MCliente>();

			try{
					x_oENT_MClienteList = GetList<ENT_MCliente>("spMClienteSelectAllByMCLI_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MClienteList;
		}


		#endregion
	}
}
