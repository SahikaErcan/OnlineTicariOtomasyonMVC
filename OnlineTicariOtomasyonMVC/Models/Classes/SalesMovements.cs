using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMVC.Models.Classes
{
    public class SalesMovements // Satış Hareketleri
    {
        [Key]
        public int SalesMovementsId { get; set; }
        public DateTime SalesMovementsHistory { get; set; }
        public int SalesMovementsPiece { get; set; } // Adet - Parça
        public decimal SalesMovementsPrice { get; set; } // Fiyat
        public decimal SalesMovementsTotalAmount { get; set; } // Toplam Tutar


        /* Ürün lazım bunun için ilişkili tablo kullanıyoruz.
       -Ürün.
       -Kime satıyoruz? Cari 
       -Kim satıyor? Personel
       */

        public ICollection<Product> Products { get; set; }
        public ICollection<Current> Currents { get; set; }
        public ICollection<Staff> Staffs { get; set; }

    }
}