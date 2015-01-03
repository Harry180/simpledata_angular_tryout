using System;

namespace SimpleData_Angular_BussinessServices.Services
{
	/// <summary>
	/// IContractorService interface.
	/// </summary>
	public interface IContractorService
	{
		dynamic GetContractorByGuid(Guid contractorGuid);

		dynamic GetAllContractors();
	}
}