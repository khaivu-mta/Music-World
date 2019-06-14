namespace ASPMVC_WebNgheNhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANNHAC")]
    public partial class BANNHAC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANNHAC()
        {
            DANHSACHNHACs = new HashSet<DANHSACHNHAC>();
            THELOAIs = new HashSet<THELOAI>();
        }

        [Key]
        public int MaBanNhac { get; set; }

        [StringLength(100)]
        public string TenBanNhac { get; set; }

        [StringLength(100)]
        public string TacGia { get; set; }

        public int? KichThuoc { get; set; }

        public int? DoDai { get; set; }

        public double? TanSo { get; set; }

        [StringLength(100)]
        public string DinhDang { get; set; }

        public int? NamSanXuat { get; set; }

        [StringLength(200)]
        public string DuongDanBanNhac { get; set; }

        [StringLength(200)]
        public string DuongDanAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHNHAC> DANHSACHNHACs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THELOAI> THELOAIs { get; set; }
    }
}
