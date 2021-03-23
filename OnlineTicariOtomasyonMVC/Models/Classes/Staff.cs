using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMVC.Models.Classes
{
    public class Staff // Personel
    {
        [Key]
        public int StaffId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string StaffFirstName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string StaffLastName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string StaffImage { get; set; }
        /* Neden string tanımlıyoruz?
         Çünkü burda görselin yolunu tutacağız.
         */

        public ICollection<SalesMovement> SalesMovements { get; set; }

        // Bir personel Bir deparmanda bulunur
        public Department Department { get; set; }
    }
}