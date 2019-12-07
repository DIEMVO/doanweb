using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class GiamGia
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên mã giảm giá")]
        public string TenMaGiamGia { get; set; }
        [Required]
        [Display(Name = "Giá trị")]
        public string GiaTri { get; set; }
    }
}
