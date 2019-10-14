using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Aptm2019.EntityLayer;

namespace Aptm2019.DataAccessLayer
{
	public partial class DAL_MUsuario : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MUsuario.
		/// </summary>
		public void Insert(ENT_MUsuario x_oENT_MUsuario)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MUSR_cUsuario", x_oENT_MUsuario.MUSR_cUsuario),
					new SqlParameter("@MUSR_cPassword", x_oENT_MUsuario.MUSR_cPassword),
					new SqlParameter("@MUSR_lActivo", x_oENT_MUsuario.MUSR_lActivo)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oENT_MUsuario.MUSR_nId = (int)ejecutarScalar("spMUsuario_Insert", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla MUsuario.
		/// </summary>
		public void Update(ENT_MUsuario x_oENT_MUsuario)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MUSR_nId", x_oENT_MUsuario.MUSR_nId),
					new SqlParameter("@MUSR_cUsuario", x_oENT_MUsuario.MUSR_cUsuario),
					new SqlParameter("@MUSR_cPassword", x_oENT_MUsuario.MUSR_cPassword),
					new SqlParameter("@MUSR_lActivo", x_oENT_MUsuario.MUSR_lActivo)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMUsuario_Update", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla MUsuario por su primary key.
		/// </summary>
		public void Delete(int MUSR_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MUSR_nId", MUSR_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("spMUsuario_Delete", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla MUsuario por su primary key.
		/// </summary>
		public ENT_MUsuario Select(int MUSR_nId)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@MUSR_nId", MUSR_nId)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			ENT_MUsuario objMUsuario = new ENT_MUsuario();
			try{
					 objMUsuario = GetEntity<ENT_MUsuario>("spMUsuario_Select", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMUsuario;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MUsuario.
		/// </summary>
		public List<ENT_MUsuario> SelectAll()
		{

			try{
				List<ENT_MUsuario> x_oENT_MUsuarioList = new List<ENT_MUsuario>();

				x_oENT_MUsuarioList = GetList<ENT_MUsuario>("spMUsuario_SelectAll");
				return x_oENT_MUsuarioList;
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}


		#endregion
	}
}
