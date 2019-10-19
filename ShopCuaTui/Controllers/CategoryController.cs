using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopCuaTui.Models;

namespace ShopCuaTui.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyDBContext db;
        public CategoryController(MyDBContext mydb)
        {
            db = mydb;
        }
        public IActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                var DsHhId = db.HangHoas.Where(p => p.MaLoai == id);
                return View(DsHhId);
            }
            var DsHH = db.HangHoas.OrderBy(p => p.TenHh);
            return View(DsHH);
        }

        public IActionResult ChiTiet(int id)
        {
            var hh = db.HangHoas.SingleOrDefault(p => p.MaHh == id);
            if(hh == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.tenThuongHieu = db.ThuongHieus.SingleOrDefault(p => p.MaTh == hh.MaTh).TenThuongHieu;

            return View(hh);
        }
    }
}