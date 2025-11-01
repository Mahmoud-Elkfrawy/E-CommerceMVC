using Depitest.Model;

namespace E_CommerceMVC.Services
{
    public class UserService
    {

        public HttpClient httpClient;
        public UserService(HttpClient _httpClient)
        {
            httpClient = _httpClient;

        }
        public List<User> Get()
        {
            HttpResponseMessage Product = httpClient.GetAsync("/api/User").Result;
            return Product.Content.ReadAsAsync<List<User>>().Result;
        }
        public User GetById(int id)
        {
            HttpResponseMessage user = httpClient.GetAsync("/api/User/" + id).Result;
            return user.Content.ReadAsAsync<User>().Result;
        }

        public User GetByName(string name)
        {
            HttpResponseMessage user = httpClient.GetAsync("/api/User/" + name).Result;
            return user.Content.ReadAsAsync<User>().Result;
        }
        public void Add(User categoray)
        {
            HttpResponseMessage user = httpClient.PostAsJsonAsync("/api/User", categoray).Result;
        }

        public void Delete(int id)
        {
            HttpResponseMessage user = httpClient.DeleteAsync("/api/User/" + id).Result;
        }
        public void Update(User categoray)
        {
            HttpResponseMessage user = httpClient.PutAsJsonAsync("/api/User", categoray).Result;
        }
    }

}
