using NurseryExample3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace NurseryExample3.Controllers
{
    public class NurseryController : Controller
    {
        private readonly ApplicationDbContext adb = null;
        public NurseryController()
        {
            adb = new ApplicationDbContext();
        }

        // GET: Nursery
        public ActionResult Index()
        {
            var nurseryproducts = adb.nurseryProducts.ToList();
            return View(nurseryproducts);//return list of product
        }
        public ActionResult Details(int id)
        {
            var product = adb.nurseryProducts.FirstOrDefault(p => p.Id == id);//nurseryProducts.Include(p => p.Name  ).
            if (product != null)
            {
                return View(product);
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var categories = adb.nurseryProducts.ToList();
            ViewBag.Categories = categories;
            return View();
        }
    }
}