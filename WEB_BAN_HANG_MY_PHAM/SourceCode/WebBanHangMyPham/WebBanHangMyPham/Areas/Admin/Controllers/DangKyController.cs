using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBanHangMyPham.Data;
using WebBanHangMyPham.Models;

namespace WebBanHangMyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DangKyController : Controller
    {

        private readonly ApplicationDbContext _db;

        public DangKyController( ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.DangKy.ToList());
        }

        //GET Creat Acgtion Method
        public IActionResult Create()
        {
            return View();
        }

        //POST Create action Method
        [HttpPost,ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DangKy dangKy)
        {
            if(ModelState.IsValid)
            {
                _db.Add(dangKy);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dangKy);
        }

        public async Task<IActionResult> Edit(int? maKhachHang)
        {
            if(maKhachHang == null)
            {
                return NotFound();
            }

            return View();
        }

        //POST Create action Method
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPOST(int? maKhachHang)
        {
            if (ModelState.IsValid)
            {
                _db.Add(dangKy);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dangKy);
        }
    }
}