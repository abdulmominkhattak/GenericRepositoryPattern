//using AspNetCore;
using GenericRepo.GenericRepository;
using GenericRepo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepo.Controllers
{
    public class CustomerController : Controller
    {

        private readonly IGenericRepository<Customer> _customer;
        public CustomerController(IGenericRepository<Customer> customer)
        {
            _customer = customer;    
        }

        public ActionResult Index()
        {
            var linqQ = from m in _customer.GetAll() select m;
            return View(linqQ);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer collection)
        {
            try
            {
                _customer.Insert(collection);
                _customer.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            Customer cus = _customer.GetById(id);   
            return View(cus);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer collection)
        {
            try
            {
                _customer.Update(collection);
                _customer.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            Customer cus = _customer.GetById(id);
            return View(cus);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Customer collection)
        {
            try
            {
                _customer.Delete(id);
                _customer.Save();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
