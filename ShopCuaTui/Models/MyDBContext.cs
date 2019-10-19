using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCuaTui.Models
{
    public class MyDBContext : DbContext
    {
        public DbSet<Loai> Loais { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }

        public MyDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
