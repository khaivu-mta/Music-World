namespace ASPMVC_WebNgheNhac.Models
{
    using System;
    using System.Collections.Generic;
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
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(200)]
        public string DuongDanAnh { get; set; }

        public int? MaQuyenTruyCap { get; set; }

        public virtual QUYENTRUYCAP QUYENTRUYCAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHNHAC> DANHSACHNHACs { get; set; }
    }
}
