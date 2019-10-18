using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCuaTui.Models
{
    public class ThuongHieu
    {
        [Key]
        [MaxLength(50)]
        public string MaTh { get; set; }
        [Required(ErrorMessage = "*")]
        [MaxLength(50)]
        public string TenThuongHieu { get; set; }
        [MaxLength(150)]
        public string DiaChi { get; set; }
        [MaxLength(50)]
        public string DienThoai { get; set; }
        [MaxLength(150)]
        public string Logo { get; set; }
        public string MoTa { get; set; }
    }
}
