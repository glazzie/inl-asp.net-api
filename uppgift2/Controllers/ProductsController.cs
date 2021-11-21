using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using uppgift2.Models;

namespace uppgift2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: ProductsController
        public async Task<ActionResult> Index()
        {
            var http = new HttpClient();
            var products = await http.GetFromJsonAsync<List<Product>>("https://localhost:44333/api/Products");
            return View(products);
        }

        // GET: ProductsController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var http = new HttpClient();
            var details = await http.GetFromJsonAsync<Product>("https://localhost:44333/api/Products/" + id);
            return View(details);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product product)
        {
            try
            {
                
                var http = new HttpClient();
                await http.PostAsJsonAsync("https://localhost:44333/api/Products", product);


                return CreatedAtAction("Index", null);
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("serverfel");
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
