using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMVC.Models.Classes
{
    public class Bill // Faturalar
    {
        [Key]
        public int Bill_Id { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string BillSerialNumber { get; set; } // Farura Seri Numarası

        [Column(TypeName = "varchar")]
        [StringLength(6)]
        public string BillRowNumber { get; set; } // Fatura Sıra Numarası

        public DateTime BillHistory { get; set; } // Tarih

        [Column(TypeName = "varchar")]
        [StringLength(60)]
        public string BillTaxAdministration { get; set; } // Vergi Dairesi
        public DateTime BillsHour { get; set; } // Saat

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string BillReceiver { get; set; } // Teslim Alan Kimse - Alıcı

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string BillDeliverer { get; set; } // Teslim Eden Kimse - Dağıtıcı
        
        // Bir faturanın birden fazla kalemi olabilir. ICollection
        public ICollection<Bill_Item>  Bill_Items { get; set; }
    }
}