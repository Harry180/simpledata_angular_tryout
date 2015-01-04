using SimpleData_Angular.Models.Seal;
using SimpleData_Angular_BussinessServices.Services;
using SimpleData_Angular_BussinessServices.Services.Impl;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SimpleData_Angular.Controllers
{
	public class SealController : Controller
	{
		#region Dependencies

		private readonly ISealService _sealService;

		#endregion

		#region Constructor

		public SealController()
		{
			_sealService = new SealService();
		}

		#endregion

		public ActionResult Index()
		{
			return View();
		}

		public JsonResult GetSeals()
		{
			IEnumerable<SealViewModel> seals = _sealService.GetAllSeals();
			return Json(seals, JsonRequestBehavior.AllowGet);
		}

	}
}
