using Depitest.Model;
using System.Net.Http;

namespace E_CommerceMVC.Services
{
    public class CategoryService
    {
        public HttpClient httpClient;
        public CategoryService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
            httpClient.BaseAddress = new Uri("https://localhost:7145/");

        }
        public List<User> Get()
        {
            HttpResponseMessage Product = httpClient.GetAsync("/api/Category").Result;
            return Product.Content.ReadAsAsync<List<User>>().Result;
        }

        public User GetById(int id)
        {
            HttpResponseMessage Product = httpClient.GetAsync("/api/Category/" + id).Result;
            return Product.Content.ReadAsAsync<User>().Result;
        }
        public User GetByName(string name)
        {
            HttpResponseMessage Product = httpClient.GetAsync("/api/Category/" + name).Result;
            return Product.Content.ReadAsAsync<User>().Result;
        }
        public void Add(User categoray)
        {
            HttpResponseMessage Product = httpClient.PostAsJsonAsync("/api/Category", categoray).Result;
        }

        public void Delete(int id)
        {

            HttpResponseMessage Product = httpClient.DeleteAsync("/api/Category/" + id).Result;
        }
        public void Update(User categoray)
        {

            HttpResponseMessage Product = httpClient.PutAsJsonAsync("/api/Category", categoray).Result;
        }
    }
}
