using Microsoft.AspNetCore.Mvc;
using RighesJoy.Models;
using System.Collections.Generic;

namespace RighesJoy.Controllers
{
    public class ProductController : Controller
    {
        // Static list to simulate a DB 
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Arbu_Clear", Description = "Alpha Arbutine", Price = 199 },
            new Product { Id = 2, Name = "Glyco_Peel", Description = "Glycolic Acide", Price = 299 },
            new Product { Id = 3, Name = "Glow_C", Description = "Vitamine C", Price = 100 },
            new Product { Id = 4, Name = "Block_Sun", Description = "Sun Screen", Price = 250 },
            new Product { Id = 5, Name = "Mice_Clean", Description = "Micellar water", Price = 50}
        };
        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Catalog()
        {
            return View(products); // Gives list of products to the view Catalog.cshtml
        }

        // Action To show product's details 
        public IActionResult Details(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View("ProductDescription",product); // Use the view ProductDescription.cshtml
        }
    }
}

