using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuanLySinhVien.Models
{
    public class DangNhap
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MSSV { get; set; }
        [Required]
        public string Pass { get; set; }
        [Required]
        public string User { get; set; }
    }
}
