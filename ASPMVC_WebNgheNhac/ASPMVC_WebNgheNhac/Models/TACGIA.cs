namespace ASPMVC_WebNgheNhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
        [DisplayName("Mã tác giả")]
        public int MaTacGia { get; set; }

        [StringLength(100)]
        [DisplayName("Tên tác giả")]
        public string HoTen { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime? NgaySinh { get; set; }

        [DisplayName("Ngày bắt đầu")]
        public DateTime? NgayBatDau { get; set; }

        [DisplayName("Số lượng bài hát")]
        public int? SoLuongBaiHat { get; set; }

        [StringLength(2000)]
        [DisplayName("Lời giới thiệu")]
        public string GioiThieu { get; set; }

        [StringLength(200)]
        [DisplayName("Đường dẫn ảnh")]
        public string DuongDanAnh { get; set; }

        [StringLength(200)]
        [DisplayName("Liên kết")]
        public string LienKet { get; set; }

        [DisplayName("Hiển thị trên trang chủ")]
        public bool HienThiTrenTrangChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANNHAC> BANNHACs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHNHAC> DANHSACHNHACs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANNHAC> BANNHACs1 { get; set; }
    }
}
