using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MProveedor
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MProveedor.
		/// </summary>
		public void Insert(ENT_MProveedor x_oENT_MProveedor)
		{
			 new DAL_MProveedor().Insert(x_oENT_MProveedor);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MProveedor.
		/// </summary>
		public void Update(ENT_MProveedor x_oENT_MProveedor)
		{
			 new DAL_MProveedor().Update(x_oENT_MProveedor);
		}

		/// <summary>
		/// Elimina un registro de la tabla MProveedor por su primary key.
		/// </summary>
		public void Delete(int MPROV_nId)
		{
			 new DAL_MProveedor().Delete(MPROV_nId);
		}

		/// <summary>
		/// Deletes a record from the MProveedor table by a foreign key.
		/// </summary>
		public void DeleteAllByMPROV_nTipoDoc(int MPROV_nTipoDoc)
		{
			 new DAL_MProveedor().DeleteAllByMPROV_nTipoDoc(MPROV_nTipoDoc);
		}

		/// <summary>
		/// Deletes a record from the MProveedor table by a foreign key.
		/// </summary>
		public void DeleteAllByMPROV_nUsrReg(int MPROV_nUsrReg)
		{
			 new DAL_MProveedor().DeleteAllByMPROV_nUsrReg(MPROV_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the MProveedor table by a foreign key.
		/// </summary>
		public void DeleteAllByMPROV_nUsrMod(int MPROV_nUsrMod)
		{
			 new DAL_MProveedor().DeleteAllByMPROV_nUsrMod(MPROV_nUsrMod);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MProveedor por su primary key.
		/// </summary>
		public ENT_MProveedor Select(int MPROV_nId)
		{
			return new DAL_MProveedor().Select(MPROV_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MProveedor.
		/// </summary>
		public List<ENT_MProveedor> SelectAll()
		{
			 return new DAL_MProveedor().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla MProveedor por un foreign key.
		/// </summary>
		public List<ENT_MProveedor> SelectAllByMPROV_nTipoDoc(int MPROV_nTipoDoc)
		{
			return new DAL_MProveedor().SelectAllByMPROV_nTipoDoc(MPROV_nTipoDoc);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MProveedor por un foreign key.
		/// </summary>
		public List<ENT_MProveedor> SelectAllByMPROV_nUsrReg(int MPROV_nUsrReg)
		{
			return new DAL_MProveedor().SelectAllByMPROV_nUsrReg(MPROV_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MProveedor por un foreign key.
		/// </summary>
		public List<ENT_MProveedor> SelectAllByMPROV_nUsrMod(int MPROV_nUsrMod)
		{
			return new DAL_MProveedor().SelectAllByMPROV_nUsrMod(MPROV_nUsrMod);
		}


		#endregion
	}
}
