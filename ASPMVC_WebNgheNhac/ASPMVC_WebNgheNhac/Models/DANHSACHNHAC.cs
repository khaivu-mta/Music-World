namespace ASPMVC_WebNgheNhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
        [DisplayName("Mã danh sách")]
        public int MaDanhSach { get; set; }

        [StringLength(100)]
        [DisplayName("Tên album")]
        public string TenDanhSach { get; set; }

        [DisplayName("Mã tác giả")]
        public int? MaTacGia { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? NgayTao { get; set; }

        [DisplayName("Lượng truy cập")]
        public int? LuongTruyCap { get; set; }

        [StringLength(200)]
        [DisplayName("Đường dẫn trực tuyến")]
        public string DuongDanTrucTuyen { get; set; }

        [StringLength(100)]
        [DisplayName("Đường dẫn ảnh")]
        public string DuongDanAnh { get; set; }

        [DisplayName("Tác giả")]
        public virtual TACGIA TACGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANNHAC> BANNHACs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOIDUNG> NGUOIDUNGs { get; set; }
    }
}
