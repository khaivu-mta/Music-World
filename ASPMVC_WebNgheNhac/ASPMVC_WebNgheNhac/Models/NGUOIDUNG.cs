namespace ASPMVC_WebNgheNhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOIDUNG")]
    public partial class NGUOIDUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOIDUNG()
        {
            DANHSACHNHACs = new HashSet<DANHSACHNHAC>();
        }

        [Key]
        [StringLength(100)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Mật khẩu")]
        public string MatKhau { get; set; }

        [StringLength(100)]
        [DisplayName("Tên người dùng")]
        public string HoTen { get; set; }

        [StringLength(200)]
        [DisplayName("Đường dẫn ảnh")]
        public string DuongDanAnh { get; set; }

        [DisplayName("Mã quyền truy cập")]
        public int? MaQuyenTruyCap { get; set; }

        [DisplayName("Quyền truy cập")]
        public virtual QUYENTRUYCAP QUYENTRUYCAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHNHAC> DANHSACHNHACs { get; set; }
    }
}
