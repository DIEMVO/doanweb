using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class ThongTinSanPham
    {
        [Key]
        public int MaSanPham { get; set; }
        [Required]
        public string TenSanPham { get; set; }
        [Required]
        public int DonGia { get; set; }
        [Required]
        public string HangSanXuat { get; set; }

    }
}
