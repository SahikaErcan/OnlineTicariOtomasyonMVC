using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMVC.Models.Classes
{
    public class Current // Cari
    {
        [Key]
        public int CurrentId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string CurrentFirstName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string CurrentLastName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(13)]
        public string CurrentCity { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string CurrentMail { get; set; }

        public SalesMovements SalesMovements { get; set; }
    }
}