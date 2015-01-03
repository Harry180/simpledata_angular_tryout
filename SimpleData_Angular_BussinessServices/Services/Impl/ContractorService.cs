using System;

namespace SimpleData_Angular_BussinessServices.Services.Impl
{
	public class ContractorService : IContractorService
	{
		#region IContractorService Members

		public dynamic GetContractorByGuid(Guid contractorGuid)
		{
			return BaseService.Db.Contractors.Get(contractorGuid);
		}

		public dynamic GetAllContractors()
		{
			return BaseService.Db.Contractors.FindAllByIsActive(true);
		}

		#endregion
	}
}
