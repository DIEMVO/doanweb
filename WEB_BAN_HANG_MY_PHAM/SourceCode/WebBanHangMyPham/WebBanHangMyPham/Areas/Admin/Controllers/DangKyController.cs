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

        //GET - Edit
        public async Task<IActionResult> Edit(int? maKhachHang)
        {
            if(maKhachHang == null)
            {
                return NotFound();
            }
            var makhachhang = await _db.DangKy.FindAsync(maKhachHang);
            if (makhachhang==null)
            {
                return NotFound();
            }

            return View(makhachhang);
        }

        //POST Create action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DangKy dangky)
        {
            if (ModelState.IsValid)
            {
                _db.Update(dangky);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(dangky);
        }

        //GET - Delete
        public async Task<IActionResult> Delete(int? maKhachHang)
        {
            if (maKhachHang == null)
            {
                return NotFound();
            }
            var makhachhang = await _db.DangKy.FindAsync(maKhachHang);
            if (makhachhang == null)
            {
                return NotFound();
            }

            return View(makhachhang);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteComfirmed(int? maKhachHang)
        {
            var makhachhang = await _db.DangKy.FindAsync(maKhachHang);
            if (makhachhang==null)
            {
                return View();
            }
            _db.DangKy.Remove(makhachhang);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}