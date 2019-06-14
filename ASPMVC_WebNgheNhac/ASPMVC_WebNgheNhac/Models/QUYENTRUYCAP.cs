namespace ASPMVC_WebNgheNhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUYENTRUYCAP")]
    public partial class QUYENTRUYCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUYENTRUYCAP()
        {
            NGUOIDUNGs = new HashSet<NGUOIDUNG>();
        }

        [Key]
        [DisplayName("Mã quyền truy cập")]
        public int MaQuyenTruyCap { get; set; }

        [StringLength(100)]
        [DisplayName("Tên quyền truy cập")]
        public string TenQuyenTruyCap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOIDUNG> NGUOIDUNGs { get; set; }
    }
}
