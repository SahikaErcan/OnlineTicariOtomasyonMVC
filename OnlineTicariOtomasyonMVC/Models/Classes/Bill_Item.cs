using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMVC.Models.Classes
{
    public class Bill_Item // Fatura Kalemi
    {
        [Key]
        public int Bill_Item_Id { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Bill_Item_Explanation { get; set; } // Açıklama
        public int Bill_Item_Quantity { get; set; } // Miktar
        public decimal Bill_Item_UnitPrice { get; set; } // Birim Fiyat
        public decimal Bill_Item_Amount { get; set; } // Fatura Kalemi Tutar
        // Bir fatura kaleminin 1 tane faturası olabilir.
        public Bills Bills { get; set; } // Bire Çok İlişki
    }
}