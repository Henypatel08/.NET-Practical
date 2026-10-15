using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Practical6.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Description = "HP Victus",
                    Price = 75000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "Mobile",
                    Description = "Samsung Mobile",
                    Price = 80000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 3,
                    ProductName = "Headphones",
                    Description = "Bluetooth Wireless Headphones",
                    Price = 2500,
                    Category = "Accessories"
                }
            };

            return View(products);
        }

        public ActionResult Details(int id)
        {
            List<Product> products = new List<Product>()
            {
                new Product { ProductId = 1, ProductName = "Laptop", Description = "Victus Laptop", Price = 75000, Category = "Electronics" },
                new Product { ProductId = 2, ProductName = "Mobile", Description = "Samsung Mobile", Price = 80000, Category = "Electronics" },
                new Product { ProductId = 3, ProductName = "Headphones", Description = " Bletooth Wireless Headphones", Price = 2500, Category = "Accessories" }
            };

            Product product = products.FirstOrDefault(p => p.ProductId == id);

            return View(product);
        }
    }
}