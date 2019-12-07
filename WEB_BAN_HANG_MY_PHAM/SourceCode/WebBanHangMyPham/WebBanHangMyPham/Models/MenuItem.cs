﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string MoTa { get; set; }
        public string Image { get; set; }

        [Display(Name = "Loại sản phẩm")]
        public int LoaiSanPhamId  { get; set; }

        [ForeignKey("LoaiSanPhamId")]
        public virtual ThongTinLoaiSanPham ThongTinLoaiSanPham { get; set; }

        [Display(Name = "Sản phẩm")]
        public int SanPhamId { get; set; }

        [ForeignKey("SanPhamId")]
        public virtual ThongTinSanPham ThongTinSanPham { get; set; }

        [Range(1,int.MaxValue, ErrorMessage = "Price shoule be greater than ${1}")]
        public double Price { get; set; }
    }
}
