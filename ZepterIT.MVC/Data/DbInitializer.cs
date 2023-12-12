using ZepterIT.Data.DataAccess;
using ZepterIT.Data.Models;

namespace ZepterIT.MVC.Data
{
	public class DbInitializer
	{
		public static void Initialize(DataContext context)
		{
			if (context.Shops.Any())
			{
				return;   // DB has been seeded
			}

			for (int i = 1; i <= 10; i++)
			{
				context.Shops.Add(new Shop { ID = i, Name = "Sklep " + i.ToString() });
			}

			context.SaveChanges();
		}
	}
}
