using Depitest.Model;

namespace E_CommerceMVC.Services
{
    public class ProductService
    {
        public HttpClient httpClient;
        public ProductService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
            httpClient.BaseAddress = new Uri("https://localhost:7145/");

        }
        public List<User> Get()
        {
            HttpResponseMessage Product = httpClient.GetAsync("/api/Product").Result;
            return Product.Content.ReadAsAsync<List<User>>().Result;
        }

        public User GetById(int id)
        {
            HttpResponseMessage Product = httpClient.GetAsync("/api/Product/" + id).Result;
            return Product.Content.ReadAsAsync<User>().Result;
        }


        public User GetByName(string name)
        {
            HttpResponseMessage Product = httpClient.GetAsync("/api/Product/" + name).Result;
            return Product.Content.ReadAsAsync<User>().Result;
        }
        public void Add(User categoray)
        {
            HttpResponseMessage Product = httpClient.PostAsJsonAsync("/api/Product", categoray).Result;
        }

        public void Delete(int id)
        {

            HttpResponseMessage Product = httpClient.DeleteAsync("/api/Product/" + id).Result;
        }
        public void Update(User categoray)
        {

            HttpResponseMessage Product = httpClient.PutAsJsonAsync("/api/Product", categoray).Result;
        }
    }
}
