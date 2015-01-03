using Simple.Data;

namespace SimpleData_Angular_BussinessServices.Services
{
	/// <summary>
	/// BaseService class.
	/// </summary>
	public static class BaseService
	{
		private static readonly dynamic _db;

		public static dynamic Db
		{
			get { return _db; }
		}

		static BaseService()
		{
			_db = Database.OpenNamedConnection("MyConnection");
		}
	}
}
