using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCuaTui.Models
{
    public class QuangCao
    {
        [Key]
        public int MaQC { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }

        [Display(Name = "Mã hàng hóa")]
        public int MaHh { get; set; }
        [ForeignKey("MaHh")]
        public HangHoa HangHoa { get; set; }
    }
}
