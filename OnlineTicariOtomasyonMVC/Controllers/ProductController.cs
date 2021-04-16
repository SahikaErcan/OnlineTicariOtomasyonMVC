using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTicariOtomasyonMVC.Models.Classes;
namespace OnlineTicariOtomasyonMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        Context c = new Context();
        public ActionResult Index()
        { // Sadece durumu true olanları listeleyecek...
            var products = c.Products.Where(x => x.Status == true).ToList();
            return View(products);
        } 
        [HttpGet]
        public ActionResult NewProduct()
        {// ürüne ait kategorileri listelemek için
            List<SelectListItem> value = (from x in c.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName,
                                              Value = x.CategoryId.ToString()
                                          }).ToList();

            // ViewBag Controller tarafından veri taşımak için kullanılıyor.
            //ViewBag.isim_gir(değişken ismi gibi)
            ViewBag.value1 = value;
            return View();
        }
        [HttpPost]
        public ActionResult NewProduct(Product product)
        {
            c.Products.Add(product);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ProductDelete(int id)
        {
            var value = c.Products.Find(id);
            value.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ProductBring(int id) 
        {
            // ürüne ait kategorileri listelemek için
            List<SelectListItem> value = (from x in c.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName,
                                              Value = x.CategoryId.ToString()
                                          }).ToList();

            // ViewBag Controller tarafından veri taşımak için kullanılıyor.
            //ViewBag.isim_gir(değişken ismi gibi)
            ViewBag.value1 = value;

            var productValue = c.Products.Find(id);
            return View("ProductBring", productValue);
        }

        public ActionResult ProductUpdate(Product p)
        {
            var value = c.Products.Find(p.ProductId);
            value.ProductName = p.ProductName;
            value.Brand = p.Brand;
            value.Stock = p.Stock;
            value.PurchasePrice = p.PurchasePrice;
            value.SellingPrice = p.SellingPrice;
            value.ProductImage = p.ProductImage;
            value.Status = p.Status;
            value.CategoryId = p.CategoryId;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}