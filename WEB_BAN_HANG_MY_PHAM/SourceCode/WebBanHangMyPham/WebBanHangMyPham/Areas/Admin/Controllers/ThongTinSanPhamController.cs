using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBanHangMyPham.Data;
using WebBanHangMyPham.Models.ViewModels;

namespace WebBanHangMyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThongTinSanPhamController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ThongTinSanPhamController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.ThongTinSanPham.Include(s=>s.ThongTinLoaiSanPham).ToListAsync());
        }

//-----------------------------------------------CREATE--------------------------------------

        //GET Creat Acgtion Method
        public async Task<IActionResult> Create()
        {
            TTinAndLoaiSanPhamViewModels model = new TTinAndLoaiSanPhamViewModels()
            {
                LoaiSPList = await _db.ThongTinLoaiSanPham.ToListAsync(),
                ThongTinSanPham = new Models.ThongTinSanPham(),
                SanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.TenSanPham).Select(p => p.TenSanPham).Distinct().ToListAsync()
            };

            return View(model);
        }

    }
}