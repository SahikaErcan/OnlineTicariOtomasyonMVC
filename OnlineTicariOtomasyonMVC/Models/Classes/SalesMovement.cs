using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMVC.Models.Classes
{
    public class SalesMovement // Satış Hareketleri
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

        public Product Product { get; set; }
        public Current Current { get; set; }
        public Staff Staff { get; set; }

    }
}