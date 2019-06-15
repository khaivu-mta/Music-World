namespace ASPMVC_WebNgheNhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TACGIA")]
    public partial class TACGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TACGIA()
        {
            BANNHACs = new HashSet<BANNHAC>();
            DANHSACHNHACs = new HashSet<DANHSACHNHAC>();
            BANNHACs1 = new HashSet<BANNHAC>();
        }

        [Key]
        public int MaTacGia { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public int? SoLuongBaiHat { get; set; }

        [StringLength(2000)]
        public string GioiThieu { get; set; }

        [StringLength(200)]
        public string DuongDanAnh { get; set; }

        [StringLength(200)]
        public string LienKet { get; set; }

        public bool HienThiTrenTrangChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANNHAC> BANNHACs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHNHAC> DANHSACHNHACs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANNHAC> BANNHACs1 { get; set; }
    }
}
