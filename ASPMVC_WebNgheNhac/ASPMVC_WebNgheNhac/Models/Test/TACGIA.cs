//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPMVC_WebNgheNhac.Models.Test
{
    using System;
    using System.Collections.Generic;
    
    public partial class TACGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TACGIA()
        {
            this.BANNHACs = new HashSet<BANNHAC>();
            this.DANHSACHNHACs = new HashSet<DANHSACHNHAC>();
            this.BANNHACs1 = new HashSet<BANNHAC>();
        }
    
        public int MaTacGia { get; set; }
        public string HoTen { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<int> SoLuongBaiHat { get; set; }
        public string GioiThieu { get; set; }
        public string DuongDanAnh { get; set; }
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
