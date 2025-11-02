using E_CommerceMVC.Model;

namespace E_CommerceMVC.Services
{
    public class ProductService
    {
        public HttpClient httpClient;
        public ProductService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7145/");

        }
        public List<Product> Get()
        {
            HttpResponseMessage Product = httpClient.GetAsync("/api/Product").Result;
            return Product.Content.ReadAsAsync<List<Product>>().Result;
        }
        public List<Product> GetByCategory(int id)
        {
            HttpResponseMessage Product = httpClient.GetAsync("/api/Product/CategoryId/" + id).Result;
            return Product.Content.ReadAsAsync<List<Product>>().Result;
        }

        public Product GetById(int id)
        {
            HttpResponseMessage Product = httpClient.GetAsync("/api/Product/" + id).Result;
            return Product.Content.ReadAsAsync<Product>().Result;
        }


        public Product GetByName(string name)
        {
            HttpResponseMessage Product = httpClient.GetAsync("/api/Product/" + name).Result;
            return Product.Content.ReadAsAsync<Product>().Result;
        }
        public void Add(Product categoray)
        {
            HttpResponseMessage Product = httpClient.PostAsJsonAsync("/api/Product", categoray).Result;
        }

        public void Delete(int id)
        {

            HttpResponseMessage Product = httpClient.DeleteAsync("/api/Product/" + id).Result;
        }
        public void Update(Product categoray)
        {

            HttpResponseMessage Product = httpClient.PutAsJsonAsync("/api/Product", categoray).Result;
        }
    }
}
