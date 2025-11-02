using E_CommerceMVC.Model;
using System.Net.Http;

namespace E_CommerceMVC.Services
{
    public class CategoryService
    {
        public HttpClient httpClient;
        public CategoryService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7145/");

        }
        public List<Category> Get()
        {
            HttpResponseMessage category = httpClient.GetAsync("/api/Category").Result;
            return category.Content.ReadAsAsync<List<Category>>().Result;
        }

        public Category GetById(int id)
        {
            HttpResponseMessage category = httpClient.GetAsync("/api/Category/" + id).Result;
            return category.Content.ReadAsAsync<Category>().Result;
        }
        public Category GetByName(string name)
        {
            HttpResponseMessage Product = httpClient.GetAsync("/api/Category/" + name).Result;
            return Product.Content.ReadAsAsync<Category>().Result;
        }
        public void Add(Category categoray)
        {
            HttpResponseMessage category = httpClient.PostAsJsonAsync("/api/Category", categoray).Result;
        }

        public void Delete(int id)
        {

            HttpResponseMessage category = httpClient.DeleteAsync("/api/Category/" + id).Result;
        }
        public void Update(Category categoray)
        {

            HttpResponseMessage category = httpClient.PutAsJsonAsync("/api/Category", categoray).Result;
        }
    }
}
