using SimpleData_Angular_BussinessServices.Services;
using System.Web.Mvc;

namespace SimpleData_Angular.Controllers
{
	public class SealController : Controller
	{
		#region Dependencies

		private readonly ISealService _sealService;

		#endregion

		#region Constructor

		public SealController(ISealService sealService)
		{
			_sealService = sealService;
		}

		#endregion

		public ActionResult Index()
		{
			return View();
		}

		public JsonResult GetSeals()
		{
			var seals = _sealService.GetAllSeals();
			return Json(seals, JsonRequestBehavior.AllowGet);
		}

	}
}
