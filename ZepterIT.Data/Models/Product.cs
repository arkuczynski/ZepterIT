namespace ZepterIT.Data.Models
{
	public class Product
	{
        public int ID { get; set; }

		public double NetPrice { get; set; }
		public double GrossPrice { get; set; }

		public ICollection<OrderProduct>? Orders { get; set; }
    }
}
