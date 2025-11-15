using E_CommerceMVC.Model;
using E_CommerceMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace E_CommerceMVC.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendToApi(IFormFile photo, string username, string password)
        {
            if (photo == null || photo.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            // Convert photo to Base64
            string base64Image;
            using (var ms = new MemoryStream())
            {
                await photo.CopyToAsync(ms);
                var fileBytes = ms.ToArray();
                base64Image = Convert.ToBase64String(fileBytes);
            }

            // Prepare object to send to API
            var data = new
            {
                Username = username,
                Password = password,
                PhotoBase64 = base64Image
            };

            using var httpClient = new HttpClient();
            var json = System.Text.Json.JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("https://localhost:7145/api/User/register", content);

            var result = await response.Content.ReadAsStringAsync();
            return Content(result);
        }


    }
}
