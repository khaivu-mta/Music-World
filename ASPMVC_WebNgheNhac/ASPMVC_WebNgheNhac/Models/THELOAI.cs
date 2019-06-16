namespace ASPMVC_WebNgheNhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THELOAI")]
    public partial class THELOAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THELOAI()
        {
            BANNHACs = new HashSet<BANNHAC>();
        }

        [Key]
        [DisplayName("Mã thể loại")]
        public int MaTheLoai { get; set; }

        [StringLength(100)]
        [DisplayName("Tên thể loại")]
        public string TenTheLoai { get; set; }

        [StringLength(100)]
        [DisplayName("Đường dẫn ảnh")]
        public string DuongDanAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANNHAC> BANNHACs { get; set; }
    }
}
