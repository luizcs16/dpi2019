using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MRepartoItem
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MRepartoItem.
		/// </summary>
		public void Insert(ENT_MRepartoItem x_oENT_MRepartoItem)
		{
			 new DAL_MRepartoItem().Insert(x_oENT_MRepartoItem);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MRepartoItem.
		/// </summary>
		public void Update(ENT_MRepartoItem x_oENT_MRepartoItem)
		{
			 new DAL_MRepartoItem().Update(x_oENT_MRepartoItem);
		}

		/// <summary>
		/// Elimina un registro de la tabla MRepartoItem por su primary key.
		/// </summary>
		public void Delete(int MRPITM_nId)
		{
			 new DAL_MRepartoItem().Delete(MRPITM_nId);
		}

		/// <summary>
		/// Deletes a record from the MRepartoItem table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPITM_nTipoComprobante(int MRPITM_nTipoComprobante)
		{
			 new DAL_MRepartoItem().DeleteAllByMRPITM_nTipoComprobante(MRPITM_nTipoComprobante);
		}

		/// <summary>
		/// Deletes a record from the MRepartoItem table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPITM_nEstado(int MRPITM_nEstado)
		{
			 new DAL_MRepartoItem().DeleteAllByMRPITM_nEstado(MRPITM_nEstado);
		}

		/// <summary>
		/// Deletes a record from the MRepartoItem table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPITM_nIdCliente(int MRPITM_nIdCliente)
		{
			 new DAL_MRepartoItem().DeleteAllByMRPITM_nIdCliente(MRPITM_nIdCliente);
		}

		/// <summary>
		/// Deletes a record from the MRepartoItem table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPITM_nUsrReg(int MRPITM_nUsrReg)
		{
			 new DAL_MRepartoItem().DeleteAllByMRPITM_nUsrReg(MRPITM_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the MRepartoItem table by a foreign key.
		/// </summary>
		public void DeleteAllByMRPITM_nUsrMod(int MRPITM_nUsrMod)
		{
			 new DAL_MRepartoItem().DeleteAllByMRPITM_nUsrMod(MRPITM_nUsrMod);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MRepartoItem por su primary key.
		/// </summary>
		public ENT_MRepartoItem Select(int MRPITM_nId)
		{
			return new DAL_MRepartoItem().Select(MRPITM_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MRepartoItem.
		/// </summary>
		public List<ENT_MRepartoItem> SelectAll()
		{
			 return new DAL_MRepartoItem().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla MRepartoItem por un foreign key.
		/// </summary>
		public List<ENT_MRepartoItem> SelectAllByMRPITM_nTipoComprobante(int MRPITM_nTipoComprobante)
		{
			return new DAL_MRepartoItem().SelectAllByMRPITM_nTipoComprobante(MRPITM_nTipoComprobante);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MRepartoItem por un foreign key.
		/// </summary>
		public List<ENT_MRepartoItem> SelectAllByMRPITM_nEstado(int MRPITM_nEstado)
		{
			return new DAL_MRepartoItem().SelectAllByMRPITM_nEstado(MRPITM_nEstado);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MRepartoItem por un foreign key.
		/// </summary>
		public List<ENT_MRepartoItem> SelectAllByMRPITM_nIdCliente(int MRPITM_nIdCliente)
		{
			return new DAL_MRepartoItem().SelectAllByMRPITM_nIdCliente(MRPITM_nIdCliente);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MRepartoItem por un foreign key.
		/// </summary>
		public List<ENT_MRepartoItem> SelectAllByMRPITM_nUsrReg(int MRPITM_nUsrReg)
		{
			return new DAL_MRepartoItem().SelectAllByMRPITM_nUsrReg(MRPITM_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MRepartoItem por un foreign key.
		/// </summary>
		public List<ENT_MRepartoItem> SelectAllByMRPITM_nUsrMod(int MRPITM_nUsrMod)
		{
			return new DAL_MRepartoItem().SelectAllByMRPITM_nUsrMod(MRPITM_nUsrMod);
		}


		#endregion
	}
}
