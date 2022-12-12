using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Models;

namespace WebMarket.Controllers
{
    public class ShopController : Controller
    {
        private readonly dbMarketsContext _context;
        public ShopController(dbMarketsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductsDetail(int id)
        {
            var product = _context.Products.Where(x => x.ProductId == id).First();
            
            if(product == null)
            {
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}
