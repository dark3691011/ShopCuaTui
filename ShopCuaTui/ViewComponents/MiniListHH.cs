using Microsoft.AspNetCore.Mvc;
using ShopCuaTui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCuaTui.ViewComponents
{
    public class MiniListHH : ViewComponent
    {
        private readonly MyDBContext db;
        public MiniListHH(MyDBContext mydb)
        {
            db = mydb;
        }
        public IViewComponentResult Invoke()
        {
            int dem = 0;
            var hh = new List<HangHoa>();
            foreach(var item in db.HangHoas)
            {
                hh.Add(item);
                dem++;
                if (dem >= 1)
                {
                    break;
                }
            }
            return View(hh);
        }
    }
}
