using SimpleData_Angular_BussinessServices.Services;
using SimpleData_Angular_BussinessServices.Services.Impl;
using System.Web.Mvc;

namespace SimpleData_Angular.Controllers
{
	public class ContractorController : Controller
	{
		private readonly IContractorService _contractorService;
		public ContractorController()
		{
			_contractorService = new ContractorService();
		}

		//
		// GET: /Contractor/

		public ActionResult Index()
		{
			var result = _contractorService.GetAllContractors().ToList();
			return View(result);
		}

	}
}
