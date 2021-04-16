using OnlineTicariOtomasyonMVC.Models.Classes;
// Sınıflarıma ulaşabileceğim model klasörünü dahil ediyorum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineTicariOtomasyonMVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        Context c = new Context(); // Context sınıfında tablolar bulunuyor.

        public ActionResult Index()
        {
            var values = c.Categories.ToList(); // kategorileri bana listele
            return View(values);
        }
        // Form yüklendiği zaman index metodunun çalıştığı gibi kategori ekle metodu da çalışacak.
        // Aşağıdaki iki metod da çalışacağı için
        // İlk CategoryAdd metodunda boş sayfa dönecek
        // İkinci CategoryAdd metodunda ekleme işlemi gerçekleşecek şekilde ayarlıyoruz..
        [HttpGet] // Form yüklendiği zaman burayı çalıştır.
        public ActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost] // Butona tıkladığım zaman burayı çalıştır diyorum.
        public ActionResult CategoryAdd(Category category)
        {
            c.Categories.Add(category);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CategoryDelete(int id)
        {
            var ctg = c.Categories.Find(id);
            c.Categories.Remove(ctg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CategoryBring(int id) // Kategoori Getir
        {
            var category = c.Categories.Find(id);
            return View("CategoryBring", category); // category değişkenimden gelen değer ile birlikte
            // CategoryBring (Kategori Getir) sayfasını döndür.
        }

        public ActionResult CategoryUpdate(Category category)
        {
            var ktgr = c.Categories.Find(category.CategoryId); // sayfadaki mevcut ID yi hafızaya aldık
            ktgr.CategoryName = category.CategoryName; // mevcut değere yeni değeri atıyoruz.
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}