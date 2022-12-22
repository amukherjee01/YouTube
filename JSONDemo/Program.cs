using Newtonsoft.Json;

namespace JSONDemo

{
	[Serializable]
	public class Customer
	{
		public int Id { get; set; }
		public string CustomerName { get; set; }
		public string CustomerEmail { get; set; }
		public string CustomerPhone { get; set; }
		public DateTime PurchaseDate { get; set; }
		
	}
	class Program
	{
		static void Main(string[] args)
		{
			var customerlist = new List<Customer>()
			{
				new Customer() { Id = 100, CustomerName = "Niharika", CustomerEmail = "niharika.101@gmail.com", CustomerPhone = "89979999", PurchaseDate = new DateTime(2022, 03, 02) },
				new Customer() { Id = 101, CustomerName = "Pooja", CustomerEmail = "pooja.101@gmail.com", CustomerPhone = "66754444", PurchaseDate = new DateTime(2022, 05, 01) },
				new Customer() { Id = 102, CustomerName = "Neha", CustomerEmail = "neha.101@gmail.com", CustomerPhone = "89877766", PurchaseDate = new DateTime(2022, 08, 03) },
				new Customer() { Id = 103, CustomerName = "Saumya", CustomerEmail = "saumya.101@gmail.com", CustomerPhone = "23677855", PurchaseDate = new DateTime(2022, 07, 02) },
			};

			var jsonstring = JsonConvert.SerializeObject(customerlist);
			Console.WriteLine(jsonstring);

			var jsonstring1 = "[{\"Id\":100,\"CustomerName\":\"Niharika\",\"CustomerEmail\":\"niharika.101@gmail.com\",\"CustomerPhone\":\"89979999\",\"PurchaseDate\":\"2022-03-02T00:00:00\"},{\"Id\":101,\"CustomerName\":\"Pooja\",\"CustomerEmail\":\"pooja.101@gmail.com\",\"CustomerPhone\":\"66754444\",\"PurchaseDate\":\"2022-05-01T00:00:00\"},{\"Id\":102,\"CustomerName\":\"Neha\",\"CustomerEmail\":\"neha.101@gmail.com\",\"CustomerPhone\":\"89877766\",\"PurchaseDate\":\"2022-08-03T00:00:00\"},{\"Id\":103,\"CustomerName\":\"Saumya\",\"CustomerEmail\":\"saumya.101@gmail.com\",\"CustomerPhone\":\"23677855\",\"PurchaseDate\":\"2022-07-02T00:00:00\"}]";

			var obj = JsonConvert.DeserializeObject<List<Customer>>(jsonstring1);

			foreach(var item in obj)
			{
				Console.WriteLine($"id = {item.Id} CustomerName = {item.CustomerName} CustomerEmail = {item.CustomerEmail} Purchase date = {item.PurchaseDate}");
			}

        }
	}
}