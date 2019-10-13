using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public class DAL_MProveedor : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MProveedor.
		/// </summary>
		public void Insert(ENT_MProveedor x_oENT_MProveedor)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPROV_nTipoDoc", x_oENT_MProveedor.MPROV_nTipoDoc),
					new SqlParameter("@MPROV_nDocumento", x_oENT_MProveedor.MPROV_nDocumento),
					new SqlParameter("@MPROV_cNombre", x_oENT_MProveedor.MPROV_cNombre),
					new SqlParameter("@MPROV_cDireccion", x_oENT_MProveedor.MPROV_cDireccion),
					new SqlParameter("@MPROV_cTelefono", x_oENT_MProveedor.MPROV_cTelefono),
					new SqlParameter("@MPROV_lActivo", x_oENT_MProveedor.MPROV_lActivo),
					new SqlParameter("@MPROV_nUsrReg", x_oENT_MProveedor.MPROV_nUsrReg),
					new SqlParameter("@MPROV_dFechReg", x_oENT_MProveedor.MPROV_dFechReg),
					new SqlParameter("@MPROV_nUsrMod", x_oENT_MProveedor.MPROV_nUsrMod),
					new SqlParameter("@MPROV_dFechMod", x_oENT_MProveedor.MPROV_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MProveedor.MPROV_nId = (int)ejecutarScalar("spMProveedor_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MProveedor.
		/// </summary>
		public void Update(ENT_MProveedor x_oENT_MProveedor)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPROV_nId", x_oENT_MProveedor.MPROV_nId),
					new SqlParameter("@MPROV_nTipoDoc", x_oENT_MProveedor.MPROV_nTipoDoc),
					new SqlParameter("@MPROV_nDocumento", x_oENT_MProveedor.MPROV_nDocumento),
					new SqlParameter("@MPROV_cNombre", x_oENT_MProveedor.MPROV_cNombre),
					new SqlParameter("@MPROV_cDireccion", x_oENT_MProveedor.MPROV_cDireccion),
					new SqlParameter("@MPROV_cTelefono", x_oENT_MProveedor.MPROV_cTelefono),
					new SqlParameter("@MPROV_lActivo", x_oENT_MProveedor.MPROV_lActivo),
					new SqlParameter("@MPROV_nUsrReg", x_oENT_MProveedor.MPROV_nUsrReg),
					new SqlParameter("@MPROV_dFechReg", x_oENT_MProveedor.MPROV_dFechReg),
					new SqlParameter("@MPROV_nUsrMod", x_oENT_MProveedor.MPROV_nUsrMod),
					new SqlParameter("@MPROV_dFechMod", x_oENT_MProveedor.MPROV_dFechMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMProveedor_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MProveedor por su primary key.
		/// </summary>
		public void Delete(int MPROV_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPROV_nId", MPROV_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMProveedor_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MProveedor table by a foreign key.
		/// </summary>
		public void DeleteAllByMPROV_nTipoDoc(int MPROV_nTipoDoc)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPROV_nTipoDoc", MPROV_nTipoDoc)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMProveedorDeleteAllByMPROV_nTipoDoc", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MProveedor table by a foreign key.
		/// </summary>
		public void DeleteAllByMPROV_nUsrReg(int MPROV_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPROV_nUsrReg", MPROV_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMProveedorDeleteAllByMPROV_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the MProveedor table by a foreign key.
		/// </summary>
		public void DeleteAllByMPROV_nUsrMod(int MPROV_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPROV_nUsrMod", MPROV_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMProveedorDeleteAllByMPROV_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MProveedor por su primary key.
		/// </summary>
		public ENT_MProveedor Select(int MPROV_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MPROV_nId", MPROV_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MProveedor objMProveedor = new ENT_MProveedor();
			try{
					 objMProveedor = GetEntity<ENT_MProveedor>("spMProveedor_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMProveedor;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MProveedor.
		/// </summary>
		public List<ENT_MProveedor> SelectAll()
		{

			try{
				List<ENT_MProveedor> x_oENT_MProveedorList = new List<ENT_MProveedor>();

				x_oENT_MProveedorList = GetList<ENT_MProveedor>("spMProveedor_SelectAll");
				return x_oENT_MProveedorList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla MProveedor por un foreign key.
		/// </summary>
		public List<ENT_MProveedor> SelectAllByMPROV_nTipoDoc(int MPROV_nTipoDoc)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MPROV_nTipoDoc", MPROV_nTipoDoc)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MProveedor> x_oENT_MProveedorList = new List<ENT_MProveedor>();

			try{
					x_oENT_MProveedorList = GetList<ENT_MProveedor>("spMProveedorSelectAllByMPROV_nTipoDoc", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MProveedorList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MProveedor por un foreign key.
		/// </summary>
		public List<ENT_MProveedor> SelectAllByMPROV_nUsrReg(int MPROV_nUsrReg)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MPROV_nUsrReg", MPROV_nUsrReg)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MProveedor> x_oENT_MProveedorList = new List<ENT_MProveedor>();

			try{
					x_oENT_MProveedorList = GetList<ENT_MProveedor>("spMProveedorSelectAllByMPROV_nUsrReg", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MProveedorList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla MProveedor por un foreign key.
		/// </summary>
		public List<ENT_MProveedor> SelectAllByMPROV_nUsrMod(int MPROV_nUsrMod)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@MPROV_nUsrMod", MPROV_nUsrMod)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ENT_MProveedor> x_oENT_MProveedorList = new List<ENT_MProveedor>();

			try{
					x_oENT_MProveedorList = GetList<ENT_MProveedor>("spMProveedorSelectAllByMPROV_nUsrMod", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oENT_MProveedorList;
		}


		#endregion
	}
}
