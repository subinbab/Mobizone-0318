using BusinessLayer;
using DomainLayer;
using DomainLayer.ProductLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UILayer.Controllers
{
    public class CatalogController : Controller
    {
        ProductDbContext _context;
        IProductCatalog _catalog;
        public CatalogController(ProductDbContext context,IProductCatalog catalog)
        {
            _context = context;
            _catalog = catalog;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Brand = new List<string>() { "samsung", "oppo" };
            return View();
        }
        [HttpPost]
        public IActionResult Index(Products product)
        {
            

            return View();
        }
        public IActionResult _BrandView(ProductBrand brand)
        {
            _catalog.AddBrand(brand);
            return RedirectToAction("/");
        }
        public IActionResult AddProduct()
        {
            List<ProductBrand> barndlists = _context.productBrands.ToList();
            List<SelectListItem> brandView = barndlists.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.ToString(),
                    Value = a.ToString(),
                    Selected = false
                };
            }
            );
            ViewBag.Brands = brandView;
            return View();
        }
    }
}
