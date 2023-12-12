namespace ZepterIT.Data.Models
{
	public class Address
	{
        public int ID { get; set; }
		//public int? OrderID { get; set; }

		public string Street { get; set; }
        public string City { get; set; }
		public string PostalCode { get; set; }

		public Order Order { get; set; }
    }
}
