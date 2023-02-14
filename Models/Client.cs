namespace ASPDentistry.Models
{
	public class Client
	{
		public int ClientId { get; set; }
		public string ClientName { get; set; }
		public int PhoneNumber{ get; set; }
		public int ServiceId { get; set; }
		public Service? Services { get; set; }

	}
}
