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

            // API'den �r�nleri al�yoruz
            var response = await _httpClient.GetAsync("api/Products");

            // E�er API'den ba�ar�l� bir yan�t al�n�rsa
            if (response.IsSuccessStatusCode)
            {
                var products = await response.Content.ReadFromJsonAsync<IEnumerable<ProductModel>>();
                return View(products);  // �r�nler ile Index view'�na d�n�yoruz
            }

            // E�er API'den hata al�n�rsa
            ModelState.AddModelError("", "�r�nler y�klenirken bir hata olu�tu.");
            return View(Enumerable.Empty<ProductModel>());  // Bo� bir liste ile view'a d�n�yoruz
        }


        [HttpGet]
        public async Task<IActionResult> Details(int Id)
        {
            var response = await _httpClient.GetAsync($"api/Products/{Id}");
            if (response.IsSuccessStatusCode)
            {
                // Ba�ar�l� yan�t al�nd�ysa, veriyi JSON olarak ��z�ml�yoruz
                var product = await response.Content.ReadFromJsonAsync<ProductModel>();
                return View(product);  // �r�n detaylar�n� View'a g�nderiyoruz
            }
            ModelState.AddModelError("", "�r�n detaylar� y�klenirken bir hata olu�tu.");
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
