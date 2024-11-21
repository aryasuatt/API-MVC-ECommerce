using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreMVC.Data;
using System.Linq;

namespace CoreMVC.Controllers
{
    public class DetailsController : Controller
    {
        private readonly ILogger<DetailsController> _logger;
        private readonly ApplicationDbContext _context;


        public DetailsController(ILogger<DetailsController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> DetailsList()
        {
            try
            {
                // Veritabanından tüm ürünleri çekiyoruz
                var products = await _context.Products.ToListAsync();

                if (products == null || products.Count == 0)
                {
                    ModelState.AddModelError("", "Veritabanında ürün bulunamadı.");
                    return View(new List<ProductModel>());
                }

                // Veritabanı modelinden ProductModel'e dönüşüm yapıyoruz
                var productModels = products.Select(p => new ProductModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Stock = p.Stock,
                    ImageUrl = p.ImageUrl,
                    ImageFileName = p.ImageFileName,
                    ImageContentType = p.ImageContentType,
                    ImageData = p.ImageData
                }).ToList();

                return View(productModels); // Ürünleri view'a gönderiyoruz
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ürünler yüklenirken bir hata meydana geldi.");
                ModelState.AddModelError("", "Ürünler yüklenirken bir hata oluştu.");
                return View(new List<ProductModel>()); // Hata durumunda boş liste döneriz
            }
        }
    }
}
