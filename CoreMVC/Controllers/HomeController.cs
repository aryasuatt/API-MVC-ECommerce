using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace CoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _httpClient = new HttpClient
            {
                BaseAddress = new System.Uri("http://localhost:5219/") // API's base URL
            };
        }

        public async Task<IActionResult> Index()
        {

            // API'den ürünleri alýyoruz
            var response = await _httpClient.GetAsync("api/Products");

            // Eðer API'den baþarýlý bir yanýt alýnýrsa
            if (response.IsSuccessStatusCode)
            {
                var products = await response.Content.ReadFromJsonAsync<IEnumerable<ProductModel>>();
                return View(products);  // Ürünler ile Index view'ýna dönüyoruz
            }

            // Eðer API'den hata alýnýrsa
            ModelState.AddModelError("", "Ürünler yüklenirken bir hata oluþtu.");
            return View(Enumerable.Empty<ProductModel>());  // Boþ bir liste ile view'a dönüyoruz
        }


        [HttpGet]
        public async Task<IActionResult> Details(int Id)
        {
            var response = await _httpClient.GetAsync($"api/Products/{Id}");
            if (response.IsSuccessStatusCode)
            {
                // Baþarýlý yanýt alýndýysa, veriyi JSON olarak çözümlüyoruz
                var product = await response.Content.ReadFromJsonAsync<ProductModel>();
                return View(product);  // Ürün detaylarýný View'a gönderiyoruz
            }
            ModelState.AddModelError("", "Ürün detaylarý yüklenirken bir hata oluþtu.");
            return RedirectToAction("Index");
        }

        





        [HttpGet]
        public async Task<IActionResult> ProductDetails(int id)
        {
            // Fetch a single product's details from the API
            var response = await _httpClient.GetAsync($"api/Products/{id}");
            if (response.IsSuccessStatusCode)
            {
                var product = await response.Content.ReadFromJsonAsync<ProductModel>();
                return View(product);
            }

            ModelState.AddModelError("", "Error loading product details.");
            return RedirectToAction("ProductList");
        }

        public IActionResult Address()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
