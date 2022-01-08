namespace CameraShop.Models
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
        public int MaSP { get; set; }

        [Column(TypeName = "ntext")]
        public string TenSP { get; set; }

        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }

        public int? DonGia { get; set; }

        public int? SoLuong { get; set; }

        public int? MaLoai { get; set; }

        [Column(TypeName = "ntext")]
        public string Anh { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
