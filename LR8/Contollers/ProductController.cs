using LR8.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LR8.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
        {
            new Product { ID = 1, Name = "Борошно", Price = 25m, CreatedDate = DateTime.Now },
            new Product { ID = 2, Name = "Яйця", Price = 50m, CreatedDate = DateTime.Now },
            new Product { ID = 3, Name = "Молоко", Price = 45m, CreatedDate = DateTime.Now }
        };

            return View(products);
        }
    }
}
