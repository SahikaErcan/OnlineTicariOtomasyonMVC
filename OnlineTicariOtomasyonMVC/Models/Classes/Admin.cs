using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMVC.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string AdminUserName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string AdminPassword { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string AdminAuthority { get; set; } // Yetki
    }
}