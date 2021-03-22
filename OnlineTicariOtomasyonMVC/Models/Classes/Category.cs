using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMVC.Models.Classes
{
    public class Category
    {
        [Key] //Üzerinde bulunduğu değişkeni birincil anahtar yapar.
        public int CategoryId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string CategoryName { get; set; }
        // kategori ile ürün arasındaki ilişkiyi kuruyoruz.
        // Her kategorinin içerisinde birden fazla ürün vardır diyoruz. Bunun için ICollection inteface ini kullanıyoruz. 
        public ICollection<Product> Products { get; set; }
    }
}