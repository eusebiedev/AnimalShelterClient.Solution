using System.Threading.Tasks;
using RestSharp;

namespace AnimalShelterClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/v2/animals", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/v2/animals/{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
    public static async void Post(string newAnimal)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/v2/animals", Method.Post);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newAnimal);
      await client.PostAsync(request);
    }

    public static async void Put(int id, string newAnimal)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/v2/animals/{id}", Method.Put);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newAnimal);
      await client.PutAsync(request);
    }
    public static async void Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/v2/animals/{id}", Method.Delete);
      request.AddHeader("Content-Type", "application/json");
      await client.DeleteAsync(request);
    }
  }
}