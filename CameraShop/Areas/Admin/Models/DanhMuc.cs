namespace CameraShop.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMuc")]
    public partial class DanhMuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMuc()
        {
            SanPham = new HashSet<SanPham>();
        }

        [Key]
        [Display(Name ="Mã loại")]
        public int MaLoai { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name ="Tên loại")]
        public string TenLoai { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name ="Ghi chú")]
        public string GhiChu { get; set; }

        [Column(TypeName = "text")]
        [Display(Name ="Ảnh")]
        public string Anh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPham { get; set; }
    }
}
