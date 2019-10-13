using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MVehiculo
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MVehiculo.
		/// </summary>
		public void Insert(ENT_MVehiculo x_oENT_MVehiculo)
		{
			 new DAL_MVehiculo().Insert(x_oENT_MVehiculo);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MVehiculo.
		/// </summary>
		public void Update(ENT_MVehiculo x_oENT_MVehiculo)
		{
			 new DAL_MVehiculo().Update(x_oENT_MVehiculo);
		}

		/// <summary>
		/// Elimina un registro de la tabla MVehiculo por su primary key.
		/// </summary>
		public void Delete(int MVEH_nId)
		{
			 new DAL_MVehiculo().Delete(MVEH_nId);
		}

		/// <summary>
		/// Deletes a record from the MVehiculo table by a foreign key.
		/// </summary>
		public void DeleteAllByMVEH_nIdMModelo(int MVEH_nIdMModelo)
		{
			 new DAL_MVehiculo().DeleteAllByMVEH_nIdMModelo(MVEH_nIdMModelo);
		}

		/// <summary>
		/// Deletes a record from the MVehiculo table by a foreign key.
		/// </summary>
		public void DeleteAllByMVEH_nIdMProveedor(int MVEH_nIdMProveedor)
		{
			 new DAL_MVehiculo().DeleteAllByMVEH_nIdMProveedor(MVEH_nIdMProveedor);
		}

		/// <summary>
		/// Deletes a record from the MVehiculo table by a foreign key.
		/// </summary>
		public void DeleteAllByMVEH_nUsrReg(int MVEH_nUsrReg)
		{
			 new DAL_MVehiculo().DeleteAllByMVEH_nUsrReg(MVEH_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the MVehiculo table by a foreign key.
		/// </summary>
		public void DeleteAllByMVEH_nUsrMod(int MVEH_nUsrMod)
		{
			 new DAL_MVehiculo().DeleteAllByMVEH_nUsrMod(MVEH_nUsrMod);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MVehiculo por su primary key.
		/// </summary>
		public ENT_MVehiculo Select(int MVEH_nId)
		{
			return new DAL_MVehiculo().Select(MVEH_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MVehiculo.
		/// </summary>
		public List<ENT_MVehiculo> SelectAll()
		{
			 return new DAL_MVehiculo().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla MVehiculo por un foreign key.
		/// </summary>
		public List<ENT_MVehiculo> SelectAllByMVEH_nIdMModelo(int MVEH_nIdMModelo)
		{
			return new DAL_MVehiculo().SelectAllByMVEH_nIdMModelo(MVEH_nIdMModelo);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MVehiculo por un foreign key.
		/// </summary>
		public List<ENT_MVehiculo> SelectAllByMVEH_nIdMProveedor(int MVEH_nIdMProveedor)
		{
			return new DAL_MVehiculo().SelectAllByMVEH_nIdMProveedor(MVEH_nIdMProveedor);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MVehiculo por un foreign key.
		/// </summary>
		public List<ENT_MVehiculo> SelectAllByMVEH_nUsrReg(int MVEH_nUsrReg)
		{
			return new DAL_MVehiculo().SelectAllByMVEH_nUsrReg(MVEH_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MVehiculo por un foreign key.
		/// </summary>
		public List<ENT_MVehiculo> SelectAllByMVEH_nUsrMod(int MVEH_nUsrMod)
		{
			return new DAL_MVehiculo().SelectAllByMVEH_nUsrMod(MVEH_nUsrMod);
		}


		#endregion
	}
}
