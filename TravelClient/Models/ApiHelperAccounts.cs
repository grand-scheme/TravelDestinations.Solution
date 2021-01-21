using System.Threading.Tasks;
using RestSharp;

namespace TravelClient.Models
{
  class ApiHelperAccounts
  {
    public static async Task Post(string newAccount)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"accounts", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newAccount);
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}