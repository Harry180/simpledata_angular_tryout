using System;
using System.Collections.Generic;

namespace SimpleData_Angular_BussinessServices.Services.Impl
{
	/// <summary>
	/// SealService Class.
	/// </summary>
	public class SealService : ISealService
	{
		#region ISealService Members

		/// <summary>
		/// Gets the seal by unique identifier.
		/// </summary>
		/// <param name="sealGuid">The seal unique identifier.</param>
		public dynamic GetSealByGuid(Guid sealGuid)
		{
			return BaseService.Db.Seals.Get(sealGuid);
		}

		/// <summary>
		/// Gets all seals.
		/// </summary>
		public dynamic GetAllSeals()
		{
			var result = BaseService.Db.Seals.FindAllByIsActive(true);
			return result;
		}

		#endregion
	}
}
