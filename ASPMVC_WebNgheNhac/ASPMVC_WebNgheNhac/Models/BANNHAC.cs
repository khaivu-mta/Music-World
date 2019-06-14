namespace ASPMVC_WebNgheNhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
        [DisplayName("Mã bản nhạc")]
        public int MaBanNhac { get; set; }

        [StringLength(100)]
        [DisplayName("Tên bản nhạc")]
        public string TenBanNhac { get; set; }

        [StringLength(100)]
        [DisplayName("Tác giả")]
        public string TacGia { get; set; }

        [DisplayName("Kích thước")]
        public int? KichThuoc { get; set; }

        [DisplayName("Độ dài")]
        public int? DoDai { get; set; }

        [DisplayName("Tần số")]
        public double? TanSo { get; set; }

        [StringLength(100)]
        [DisplayName("Định dạng")]
        public string DinhDang { get; set; }

        [DisplayName("Năm sản xuất")]
        public int? NamSanXuat { get; set; }

        [StringLength(200)]
        [DisplayName("Đường dẫn bản nhạc")]
        public string DuongDanBanNhac { get; set; }

        [StringLength(200)]
        [DisplayName("Đường dẫn ảnh")]
        public string DuongDanAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHNHAC> DANHSACHNHACs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THELOAI> THELOAIs { get; set; }
    }
}
