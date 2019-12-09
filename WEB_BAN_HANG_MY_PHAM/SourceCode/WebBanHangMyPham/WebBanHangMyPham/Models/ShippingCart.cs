using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class ShippingCart
    {
        public ShippingCart()
        {
            Soluong = 1;
        }


        public int Id { get; set; }
        public string Nguoidungungdungid { get; set; }
        [NotMapped]
        [ForeignKey("Nguoidungungdungid")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        public int Mucmenu { get; set; }
        [NotMapped]
        [ForeignKey("Mucmenu")]
        public virtual MenuItem MenuItem { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value greater than or equal to {1}")]
        public int Soluong { get; set; }
    }
}
