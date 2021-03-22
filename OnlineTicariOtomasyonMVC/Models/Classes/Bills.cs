using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMVC.Models.Classes
{
    public class Bills // Faturalar
    {
        [Key]
        public int BillsId { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string BillsSerialNumber { get; set; } // Farura Seri Numarası

        [Column(TypeName = "varchar")]
        [StringLength(6)]
        public string BillsRowNumber { get; set; } // Fatura Sıra Numarası

        public DateTime BillsHistory { get; set; } // Tarih

        [Column(TypeName = "varchar")]
        [StringLength(60)]
        public int BillsTaxAdministration { get; set; } // Vergi Dairesi
        public DateTime BillsHour { get; set; } // Saat

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string BillsReceiver { get; set; } // Teslim Alan Kimse - Alıcı

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string BillsDeliverer { get; set; } // Teslim Eden Kimse - Dağıtıcı
        // Bir faturanın birden fazla kalemi olabilir. ICollection
        public ICollection<Bill_Item>  Bill_Items { get; set; }
    }
}