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
                var hhL = db.HangHoas.Where(p => p.MaLoai == id);
                return View(hhL);
            }
            
            var hh = db.HangHoas.OrderBy(p => p.TenHh);
            return View(hh);
        }
    }
}