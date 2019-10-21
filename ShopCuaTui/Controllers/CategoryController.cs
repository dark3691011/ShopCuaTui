using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopCuaTui.Models;

namespace ShopCuaTui.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyDBContext db;
        private readonly IMapper mapper;
        public CategoryController(MyDBContext mydb, IMapper m)
        {
            db = mydb;
            mapper = m;
        }
        public IActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                var DsHhId = db.HangHoas.Where(p => p.MaLoai == id);
                return View(DsHhId);
            }
            var _DsHH = db.HangHoas.OrderBy(p => p.TenHh);
            var DsHH = mapper.Map<List<HangHoaViewModel>>(_DsHH);
            return View(DsHH);
        }

        public IActionResult ChiTiet(int id)
        {
            var hh = db.HangHoas.Include(p => p.ThuongHieu).SingleOrDefault(p => p.MaHh == id);
            if(hh == null)
            {
                return RedirectToAction("Index");
            }

            return View(hh);
        }
    }
}