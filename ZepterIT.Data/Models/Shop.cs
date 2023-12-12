using System.ComponentModel.DataAnnotations.Schema;

namespace ZepterIT.Data.Models
{
	public class Shop
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ID { get; set; }
		public string Name { get; set; }

		public ICollection<Order>? Orders { get; set; }
	}
}
