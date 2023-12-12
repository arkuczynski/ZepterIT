namespace ZepterIT.Data.Models
{
	public enum PaymentMethod
	{
		cash,
		card,
		transfer
	}

	public class Order
	{
        public int ID { get; set; }
		public int ShopID {  get; set; }
		public int AddressID { get; set; }

		public double TotalValue { get; set; }
		public PaymentMethod Payment { get; set; }

		public Address Address { get; set; }
		public Shop Shop { get; set; }
		public ICollection<OrderProduct> Products { get; set; } = new List<OrderProduct>();

    }
}
