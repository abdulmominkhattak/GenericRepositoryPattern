using GenericRepo.GenericRepository;
using GenericRepo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepo.Controllers
{
    public class ProductController : Controller
    {
        

        private readonly IGenericRepository<Product> _product;
        public ProductController(IGenericRepository<Product> product)
        {
            _product = product;
        }

        public ActionResult Index()
        {
            var linqQ = from m in _product.GetAll() select m; // Linq Query to select all. return List
            return View(linqQ);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product collection)
        {
            try
            {
                _product.Insert(collection);
                _product.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            Product cus = _product.GetById(id);
            return View(cus);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product collection)
        {
            try
            {
                _product.Update(collection);
                _product.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            Product cus = _product.GetById(id);
            return View(cus);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product collection)
        {
            try
            {
                _product.Delete(id);
                _product.Save();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
