namespace CameraShop.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [Display(Name ="Mã sản phẩm")]
        public int MaSP { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name ="Tên sản phẩm")]
        public string TenSP { get; set; }

        [Display(Name ="Mô tả")]
        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }

        [Display(Name ="Đơn giá")]
        public int? DonGia { get; set; }

        [Display(Name ="Số lượng")]
        public int? SoLuong { get; set; }

        [Display(Name ="Mã loại")]
        public int? MaLoai { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name ="Ảnh")]
        public string Anh { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
