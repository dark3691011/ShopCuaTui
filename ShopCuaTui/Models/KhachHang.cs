using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCuaTui.Models
{
    public class KhachHang
    {
        [Key]
        [MaxLength(50)]
        public string MaKh { get; set; }
        [MaxLength(150)]
        [Display(Name = "Họ lót")]
        public string HoLot { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Tên")]
        public string Ten { get; set; }
        [MaxLength(150)]
        [Required(ErrorMessage = "*")]
        public string Email { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Số điện thoại")]
        public string SDT { get; set; }
        [MaxLength(150)]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }
        [MaxLength(150)]
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
    }
}
