namespace ASPMVC_WebNgheNhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHSACHNHAC")]
    public partial class DANHSACHNHAC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANHSACHNHAC()
        {
            BANNHACs = new HashSet<BANNHAC>();
            NGUOIDUNGs = new HashSet<NGUOIDUNG>();
        }

        [Key]
        public int MaDanhSach { get; set; }

        [StringLength(100)]
        public string TenDanhSach { get; set; }

        public int? MaTacGia { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? LuongTruyCap { get; set; }

        [StringLength(200)]
        public string DuongDanTrucTuyen { get; set; }

        [StringLength(100)]
        public string DuongDanAnh { get; set; }

        public virtual TACGIA TACGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANNHAC> BANNHACs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOIDUNG> NGUOIDUNGs { get; set; }
    }
}
