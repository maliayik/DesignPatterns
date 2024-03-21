using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryDesignPattern.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
          var values= _productService.TGetList();
            return View(values);
        }

        /// <summary>
        /// Category Adını getirmek için örnek olarak yazdıgımız index.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index2()
        {
            var values = _productService.TProductListWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            //Dropdown list için yazmıs oldugumuz kod.
            List<SelectListItem> values=(from x in _categoryService.TGetList()
                                         select new SelectListItem
                                         {
                                             Text=x.CategoryName,
                                             Value=x.CategoryID.ToString()
                                         }).ToList();
            ViewBag.v=values;                                        
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            //Dropdown list için yazmıs oldugumuz kod.
            List<SelectListItem> values = (from x in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
           
            var product =_productService.TGetByID(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {           
            _productService.TUpdate(product);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var product=_productService.TGetByID(id);
            _productService.TDelete(product);
            return RedirectToAction("Index");
        }

    }
}
