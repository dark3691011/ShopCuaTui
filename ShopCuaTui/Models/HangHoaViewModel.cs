using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCuaTui.Models
{
    public class HangHoaViewModel
    {
        [Display(Name = "Mã hàng hóa")]
        public int MaHh { get; set; }
        [MaxLength(150)]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Tên hàng hóa")]
        public string TenHh { get; set; }
        [Display(Name = "Đơn giá")]
        public double DonGia { get; set; }
        public string ProductImg { get; set; }
    }
}
