using Newtonsoft.Json;
using System.Net.Http;


namespace JSONDemo1
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Address
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("suite")]
        public string Suite { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("geo")]
        public Geo Geo { get; set; }
    }

    public class Company
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("catchPhrase")]
        public string CatchPhrase { get; set; }

        [JsonProperty("bs")]
        public string Bs { get; set; }
    }

    public class Geo
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }
    }

    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("company")]
        public Company Company { get; set; }
    }


    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                string url = "https://jsonplaceholder.typicode.com/users";

                HttpClient httpclient = new HttpClient();

                var responsemessage = await httpclient.GetAsync(url);
                string jsonResponse = await responsemessage.Content.ReadAsStringAsync();

                Console.WriteLine(jsonResponse);

                var obj = JsonConvert.DeserializeObject<User[]>(jsonResponse);

                foreach(var item in obj)
                {
                    Console.WriteLine($"Name = {item.Email} UserName = {item.Username} Company = {item.Company.Name} Website = {item.Website} Address = {item.Address.City}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
          
        }
    }
}