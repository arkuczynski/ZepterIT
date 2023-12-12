using Microsoft.EntityFrameworkCore;
using ZepterIT.Data.Models;

namespace ZepterIT.Data.DataAccess
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions options) : base(options) { }

		public DbSet<Address> Addresses { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderProduct> OrdersProducts { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Shop> Shops { get; set; }
	}
}
