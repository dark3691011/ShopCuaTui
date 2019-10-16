using Microsoft.AspNetCore.Mvc;
using ShopCuaTui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCuaTui.ViewComponents
{
    public class MenuLoai : ViewComponent
    {
        private readonly MyDBContext db;
        public MenuLoai(MyDBContext mydb)
        {
            db = mydb;
        }
        public IViewComponentResult Invoke(int tmp)
        {
            string MyView = "Default";
            switch (tmp){
                case 1: MyView = "Default";
                    break;
                case 2: MyView = "subMenu";
                    break;
            }
            return View(MyView,db.Loais);
        }
    }
}
