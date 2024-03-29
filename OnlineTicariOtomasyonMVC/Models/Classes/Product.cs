﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMVC.Models.Classes
{
    public class Product // Ürün
    {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName ="varchar")] // Kısıtlama
        [StringLength(30)]
        public string ProductName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Brand { get; set; } //Marka
        public short Stock { get; set; } //Stok
        public decimal PurchasePrice { get; set; } // Satın alma fiyatı
        public decimal SellingPrice { get; set; } //Satış ücreti 
        public bool Status { get; set; } //Durum

        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string ProductImage { get; set; } // Ürün görsel
        // Bir ürün bir kategoriye aittir.
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        // Her ürünün birden fazla satışı olabilir.
        public ICollection<SalesMovement> SalesMovements { get; set; } // Satış Hareketleri

    }
}