using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class ThongTinLoaiSanPham
    {
        [Key]
        public int MaLoaiSanPham { get; set; }
        [Required]
        public string TenLoaiSanPham { get; set; }
    }
}
