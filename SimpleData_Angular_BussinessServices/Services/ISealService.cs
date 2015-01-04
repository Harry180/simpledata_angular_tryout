namespace SimpleData_Angular_BussinessServices.Services
{
	/// <summary>
	/// ISealService Interface.
	/// </summary>
	public interface ISealService
	{
		/// <summary>
		/// Gets the seal by unique identifier.
		/// </summary>
		/// <param name="sealGuid">The seal unique identifier.</param>
		dynamic GetSealByGuid(Guid sealGuid);

		/// <summary>
		/// Gets all seals.
		/// </summary>
		dynamic GetAllSeals();
	}
}
