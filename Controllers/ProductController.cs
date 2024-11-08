using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Partial_View_Practice.Enums;
using Partial_View_Practice.Models;

namespace Partial_View_Practice.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> products =
        new List<Product>()
            {
                new Product() { ID = 1, Name = "Dell Lattitued", Price = 5000m, PublishStaus = PublishStaus.Published, Quantity = 14, SKU = "DELL_GTU"},
                new Product() { ID = 2, Name = "HP Pavilion", Price = 4500m, PublishStaus = PublishStaus.Scheduled, Quantity = 10, SKU = "HP_PAV123" },
                new Product() { ID = 3, Name = "Lenovo ThinkPad", Price = 5200m, PublishStaus = PublishStaus.Published, Quantity = 20, SKU = "LENOVO_THK" },
                new Product() { ID = 4, Name = "Apple MacBook Air", Price = 7500m, PublishStaus = PublishStaus.Approved, Quantity = 5, SKU = "APPLE_MBAIR" },
                new Product() { ID = 5, Name = "Asus ZenBook", Price = 4800m, PublishStaus = PublishStaus.Rejected, Quantity = 8, SKU = "ASUS_ZBK" },
                new Product() { ID = 6, Name = "Acer Aspire", Price = 4300m, PublishStaus = PublishStaus.Published, Quantity = 15, SKU = "ACER_ASP" }

            };
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public IActionResult Products()
        {
            return View(products);
        }
        public IActionResult Details(int id)
        {
            if (id <= 0) return BadRequest();
            var single_product = products.FirstOrDefault(single => single.ID == id);

            if (single_product != null)
            {
                return View(single_product);
            }
            else
            {
                return BadRequest();
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}