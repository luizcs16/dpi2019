using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MEmpleado
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MEmpleado.
		/// </summary>
		public void Insert(ENT_MEmpleado x_oENT_MEmpleado)
		{
			 new DAL_MEmpleado().Insert(x_oENT_MEmpleado);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MEmpleado.
		/// </summary>
		public void Update(ENT_MEmpleado x_oENT_MEmpleado)
		{
			 new DAL_MEmpleado().Update(x_oENT_MEmpleado);
		}

		/// <summary>
		/// Elimina un registro de la tabla MEmpleado por su primary key.
		/// </summary>
		public void Delete(int MEMP_nId)
		{
			 new DAL_MEmpleado().Delete(MEMP_nId);
		}

		/// <summary>
		/// Deletes a record from the MEmpleado table by a foreign key.
		/// </summary>
		public void DeleteAllByMEMP_nTipoDoc(int MEMP_nTipoDoc)
		{
			 new DAL_MEmpleado().DeleteAllByMEMP_nTipoDoc(MEMP_nTipoDoc);
		}

		/// <summary>
		/// Deletes a record from the MEmpleado table by a foreign key.
		/// </summary>
		public void DeleteAllByMEMP_nIdMUsuario(int MEMP_nIdMUsuario)
		{
			 new DAL_MEmpleado().DeleteAllByMEMP_nIdMUsuario(MEMP_nIdMUsuario);
		}

		/// <summary>
		/// Deletes a record from the MEmpleado table by a foreign key.
		/// </summary>
		public void DeleteAllByMEMP_nUsrReg(int MEMP_nUsrReg)
		{
			 new DAL_MEmpleado().DeleteAllByMEMP_nUsrReg(MEMP_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the MEmpleado table by a foreign key.
		/// </summary>
		public void DeleteAllByMEMP_nUsrMod(int MEMP_nUsrMod)
		{
			 new DAL_MEmpleado().DeleteAllByMEMP_nUsrMod(MEMP_nUsrMod);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MEmpleado por su primary key.
		/// </summary>
		public ENT_MEmpleado Select(int MEMP_nId)
		{
			return new DAL_MEmpleado().Select(MEMP_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MEmpleado.
		/// </summary>
		public List<ENT_MEmpleado> SelectAll()
		{
			 return new DAL_MEmpleado().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla MEmpleado por un foreign key.
		/// </summary>
		public List<ENT_MEmpleado> SelectAllByMEMP_nTipoDoc(int MEMP_nTipoDoc)
		{
			return new DAL_MEmpleado().SelectAllByMEMP_nTipoDoc(MEMP_nTipoDoc);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MEmpleado por un foreign key.
		/// </summary>
		public List<ENT_MEmpleado> SelectAllByMEMP_nIdMUsuario(int MEMP_nIdMUsuario)
		{
			return new DAL_MEmpleado().SelectAllByMEMP_nIdMUsuario(MEMP_nIdMUsuario);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MEmpleado por un foreign key.
		/// </summary>
		public List<ENT_MEmpleado> SelectAllByMEMP_nUsrReg(int MEMP_nUsrReg)
		{
			return new DAL_MEmpleado().SelectAllByMEMP_nUsrReg(MEMP_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MEmpleado por un foreign key.
		/// </summary>
		public List<ENT_MEmpleado> SelectAllByMEMP_nUsrMod(int MEMP_nUsrMod)
		{
			return new DAL_MEmpleado().SelectAllByMEMP_nUsrMod(MEMP_nUsrMod);
		}


		#endregion
	}
}
