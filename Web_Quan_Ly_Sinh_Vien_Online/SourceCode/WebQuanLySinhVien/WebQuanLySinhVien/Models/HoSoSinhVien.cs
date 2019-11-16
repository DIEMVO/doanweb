using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuanLySinhVien.Models
{
    public class HoSoSinhVien
    {
        [Key]
        public int MSSV { get; set; }
        [Required]
        public string HoVaTenLot { get; set; }
        [Required]
        public string Ten { get; set; }
        [Required]
        public string NgaySinh { get; set; }
        [Required]
        public string NoiSinh { get; set; }
        [Required]
        public string DiaChiThuongTru { get; set; }
        [Required]
        public string GioiTinh { get; set; }
        [Required]
        public string DanToc { get; set; }
        [Required]
        public string SoCMND { get; set; }
        [Required]
        public string MaKhoaHoc { get; set; }
        [Required]
        public string MaKhoa { get; set; }
        [Required]
        public string MaNganh { get; set; }
        [Required]
        public string TinhTrang { get; set; }
    }
}
