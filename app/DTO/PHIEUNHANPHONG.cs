//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUNHANPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHANPHONG()
        {
            this.PHIEUTRAPHONGs = new HashSet<PHIEUTRAPHONG>();
            this.KHACHHANGs = new HashSet<KHACHHANG>();
        }
    
        public int ID { get; set; }
        public Nullable<int> NHANVIEN_ID { get; set; }
        public Nullable<int> PHIEUDATPHONG_ID { get; set; }
        public Nullable<int> PHONG_ID { get; set; }
        public Nullable<System.DateTime> NGAYTRAPHONG { get; set; }
        public string TINHTRANG { get; set; }
        public Nullable<System.DateTime> NGAYNHANPHONG { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual PHIEUDATPHONG PHIEUDATPHONG { get; set; }
        public virtual PHONG PHONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTRAPHONG> PHIEUTRAPHONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }
    }
}
