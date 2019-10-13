using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MServicio
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MServicio.
		/// </summary>
		public void Insert(ENT_MServicio x_oENT_MServicio)
		{
			 new DAL_MServicio().Insert(x_oENT_MServicio);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MServicio.
		/// </summary>
		public void Update(ENT_MServicio x_oENT_MServicio)
		{
			 new DAL_MServicio().Update(x_oENT_MServicio);
		}

		/// <summary>
		/// Elimina un registro de la tabla MServicio por su primary key.
		/// </summary>
		public void Delete(int MSRV_nId)
		{
			 new DAL_MServicio().Delete(MSRV_nId);
		}

		/// <summary>
		/// Deletes a record from the MServicio table by a foreign key.
		/// </summary>
		public void DeleteAllByMSRV_nTipoSrv(int MSRV_nTipoSrv)
		{
			 new DAL_MServicio().DeleteAllByMSRV_nTipoSrv(MSRV_nTipoSrv);
		}

		/// <summary>
		/// Deletes a record from the MServicio table by a foreign key.
		/// </summary>
		public void DeleteAllByMSRV_nUsrReg(int MSRV_nUsrReg)
		{
			 new DAL_MServicio().DeleteAllByMSRV_nUsrReg(MSRV_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the MServicio table by a foreign key.
		/// </summary>
		public void DeleteAllByMSRV_nUsrMod(int MSRV_nUsrMod)
		{
			 new DAL_MServicio().DeleteAllByMSRV_nUsrMod(MSRV_nUsrMod);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MServicio por su primary key.
		/// </summary>
		public ENT_MServicio Select(int MSRV_nId)
		{
			return new DAL_MServicio().Select(MSRV_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MServicio.
		/// </summary>
		public List<ENT_MServicio> SelectAll()
		{
			 return new DAL_MServicio().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicio por un foreign key.
		/// </summary>
		public List<ENT_MServicio> SelectAllByMSRV_nTipoSrv(int MSRV_nTipoSrv)
		{
			return new DAL_MServicio().SelectAllByMSRV_nTipoSrv(MSRV_nTipoSrv);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicio por un foreign key.
		/// </summary>
		public List<ENT_MServicio> SelectAllByMSRV_nUsrReg(int MSRV_nUsrReg)
		{
			return new DAL_MServicio().SelectAllByMSRV_nUsrReg(MSRV_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MServicio por un foreign key.
		/// </summary>
		public List<ENT_MServicio> SelectAllByMSRV_nUsrMod(int MSRV_nUsrMod)
		{
			return new DAL_MServicio().SelectAllByMSRV_nUsrMod(MSRV_nUsrMod);
		}


		#endregion
	}
}
