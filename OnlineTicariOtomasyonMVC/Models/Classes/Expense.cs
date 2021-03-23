using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMVC.Models.Classes
{
    public class Expense // Gider
    {
        [Key]
        public int ExpenseId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string ExpenseExplanation { get; set; } // Açıklama

        public DateTime ExpenseHistory { get; set; } // Tarih
        public decimal ExpenseAmount { get; set; } // Yetki
    }
}