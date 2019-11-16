using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuanLySinhVien.Models
{
    public class Khoa
    {
        [Key]
        public string MaKhoa { get; set; }
        [Required]
        public string TenKhoa { get; set; }

    }
}
