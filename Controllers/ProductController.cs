
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practical_6.Models;

namespace Practical_6.Controllers
{
    public class ProductController : Controller
    {
        // Temporary product storage
        private static List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Laptop", Price = 45000 },
            new Product { Id = 2, Name = "Mobile", Price = 15000 },
            new Product { Id = 3, Name = "Keyboard", Price = 1000 }
        };

        // View all products
        public ActionResult Index()
        {
            return View(products);
        }

        // Open Add page
        public ActionResult Create()
        {
            return View();
        }

        // Save new product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = products.Count == 0
                    ? 1 : products.Max(p => p.Id) + 1;

                products.Add(product);

                return RedirectToAction("Index");
            }

            return View(product);
        }

        // Open Edit page
        public ActionResult Edit(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        // Save edited product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                Product existing = products.FirstOrDefault(
                    p => p.Id == product.Id);

                if (existing == null)
                    return HttpNotFound();

                existing.Name = product.Name;
                existing.Price = product.Price;

                return RedirectToAction("Index");
            }

            return View(product);
        }

        // Open Delete confirmation page
        public ActionResult Delete(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        // Delete product
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);

            if (product != null)
                products.Remove(product);

            return RedirectToAction("Index");
        }
    }
}
