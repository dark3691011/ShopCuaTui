﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCuaTui.Models
{
    public class HangHoa
    {
        [Key]
        [Display(Name = "Mã hàng hóa")]
        public int MaHh { get; set; }
        [MaxLength(150)]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Tên hàng hóa")]
        public string TenHh { get; set; }
        [Display(Name = "Mô tả")]
        [DataType(DataType.MultilineText)]
        public string MoTa { get; set; }
        [Display(Name = "Đơn giá")]
        public double DonGia { get; set; }
        [Display(Name = "Số lượng")]
        public int SoLuong { get; set; }
        [Display(Name = "Giảm giá (%)")]
        [Range(0, 100)]
        public int GiamGia { get; set; }
        public string ProductImg { get; set; }
        [Display(Name = "Hình chi tiết 1")]
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






        [Display(Name = "Loại")]
        public int MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        [Display(Name = "Loại")]
        public Loai Loai { get; set; }

        [MaxLength(50)]
        [Display(Name = "Thương hiệu")]
        public string MaTh { get; set; }
        [ForeignKey("MaTh")]
        [Display(Name = "Thương hiệu")]
        public ThuongHieu ThuongHieu { get; set; }
    } 
}
