using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZepterIT.Data.DataAccess;
using ZepterIT.Data.Models;
using ZepterIT.MVC.Models;

namespace ZepterIT.MVC.Controllers
{
	public class ReportController : Controller
	{
		private readonly DataContext _context;

		public ReportController(DataContext context)
		{
			_context = context;
		}

		public List<MVCReportViewModel> MVCReportModel { get; set; } = new List<MVCReportViewModel>();

		[HttpGet]
		public async Task<IActionResult> MVCReport()
		{
			for (int i = 0; i < 3; i++)
			{
				var data = await _context.Orders.Where(x => (x.TotalValue >= 100 & x.Payment == (PaymentMethod)i)).ToListAsync();

				MVCReportModel.Add(new MVCReportViewModel() {
					PaymentMethod = (PaymentMethod)i,
					OrdersNumber =  data.Count,
					GrossPrice = data.Sum(x => x.TotalValue)
				});
			}

			return View(MVCReportModel);
		}

		[HttpGet]
		public async Task<IActionResult> APIReport()
		{
			return View();
		}
	}
}
