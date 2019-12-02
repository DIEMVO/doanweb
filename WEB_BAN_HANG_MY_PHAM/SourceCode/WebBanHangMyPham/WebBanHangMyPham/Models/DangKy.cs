using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class DangKy
    {
        [Key]
        public int MaKhachHang { get; set; }
        [Required]
        public string TenDangNhap { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string RetypePassword { get; set; }
        [Required]
        [Display(Name ="Ten Khach Hang")]
        public string HoTen { get; set; }
        [Required]
        public int SDT { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string DiaChi { get; set; }
    }
}
