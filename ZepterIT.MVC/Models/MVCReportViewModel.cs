using ZepterIT.Data.Models;

namespace ZepterIT.MVC.Models
{
	public class MVCReportViewModel
	{
        public PaymentMethod PaymentMethod { get; set; }
		public int OrdersNumber { get; set; }
		public double GrossPrice { get; set; }
    }
}
