using System;
using System.Collections.Generic;
using Aptm2019.DataAccessLayer;
using Aptm2019.EntityLayer;

namespace Aptm2019.BusinessLogicLayer
{
	public class BLL_MCliente
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla MCliente.
		/// </summary>
		public void Insert(ENT_MCliente x_oENT_MCliente)
		{
			 new DAL_MCliente().Insert(x_oENT_MCliente);
		}

		/// <summary>
		/// Actualiza a registro de la tabla MCliente.
		/// </summary>
		public void Update(ENT_MCliente x_oENT_MCliente)
		{
			 new DAL_MCliente().Update(x_oENT_MCliente);
		}

		/// <summary>
		/// Elimina un registro de la tabla MCliente por su primary key.
		/// </summary>
		public void Delete(int MCLI_nId)
		{
			 new DAL_MCliente().Delete(MCLI_nId);
		}

		/// <summary>
		/// Deletes a record from the MCliente table by a foreign key.
		/// </summary>
		public void DeleteAllByMCLI_nTipoDoc(int MCLI_nTipoDoc)
		{
			 new DAL_MCliente().DeleteAllByMCLI_nTipoDoc(MCLI_nTipoDoc);
		}

		/// <summary>
		/// Deletes a record from the MCliente table by a foreign key.
		/// </summary>
		public void DeleteAllByMCLI_nUsrReg(int MCLI_nUsrReg)
		{
			 new DAL_MCliente().DeleteAllByMCLI_nUsrReg(MCLI_nUsrReg);
		}

		/// <summary>
		/// Deletes a record from the MCliente table by a foreign key.
		/// </summary>
		public void DeleteAllByMCLI_nUsrMod(int MCLI_nUsrMod)
		{
			 new DAL_MCliente().DeleteAllByMCLI_nUsrMod(MCLI_nUsrMod);
		}

		/// <summary>
		/// Selecciona una registro de la tabla MCliente por su primary key.
		/// </summary>
		public ENT_MCliente Select(int MCLI_nId)
		{
			return new DAL_MCliente().Select(MCLI_nId);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla MCliente.
		/// </summary>
		public List<ENT_MCliente> SelectAll()
		{
			 return new DAL_MCliente().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla MCliente por un foreign key.
		/// </summary>
		public List<ENT_MCliente> SelectAllByMCLI_nTipoDoc(int MCLI_nTipoDoc)
		{
			return new DAL_MCliente().SelectAllByMCLI_nTipoDoc(MCLI_nTipoDoc);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MCliente por un foreign key.
		/// </summary>
		public List<ENT_MCliente> SelectAllByMCLI_nUsrReg(int MCLI_nUsrReg)
		{
			return new DAL_MCliente().SelectAllByMCLI_nUsrReg(MCLI_nUsrReg);
		}

		/// <summary>
		/// Selecciona los registros de la tabla MCliente por un foreign key.
		/// </summary>
		public List<ENT_MCliente> SelectAllByMCLI_nUsrMod(int MCLI_nUsrMod)
		{
			return new DAL_MCliente().SelectAllByMCLI_nUsrMod(MCLI_nUsrMod);
		}


		#endregion
	}
}
