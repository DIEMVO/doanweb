using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuanLySinhVien.Models
{
    public class Nganh
    {
        [Key]
        public string MaNganh { get; set; }
        [Required]
        public string TenNganh { get; set; }
        [Required]
        public string MaKhoa { get; set; }
    }
}
