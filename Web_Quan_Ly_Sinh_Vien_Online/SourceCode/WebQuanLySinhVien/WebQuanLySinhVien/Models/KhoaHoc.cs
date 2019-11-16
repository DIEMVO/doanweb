using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuanLySinhVien.Models
{
    public class KhoaHoc
    {
        [Key]
        public string MaKhoaHoc { get; set; }
        [Required]
        public string TenKhoaHoc { get; set; }
        [Required]
        public string NamNhapHoc { get; set; }
        [Required]
        public string NamHetHanDaoTao { get; set; }
        [Required]
        public string TenChuongTrinhDaoTao { get; set; }

    }
}
