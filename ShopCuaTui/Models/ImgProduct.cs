using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCuaTui.Models
{
    public class ImgProduct
    {
        [Key]
        [Display(Name ="Mã hình")]
        public int ImgID { get; set; }
        [Display(Name ="Hình sản phẩm")]
        [MaxLength(150)]
        public string ProductImg { get; set; }
        [Display(Name="Hình chi tiết 1")]
        [MaxLength(150)]
        public string SingleProductImg1 { get; set; }
        [Display(Name = "Hình chi tiết 2")]
        [MaxLength(150)]
        public string SingleProductImg2 { get; set; }
        [Display(Name = "Hình chi tiết 3")]
        [MaxLength(150)]
        public string SingleProductImg3 { get; set; }
        [Display(Name = "Hình chi tiết 4")]
        [MaxLength(150)]
        public string SingleProductImg4 { get; set; }
    }
}
