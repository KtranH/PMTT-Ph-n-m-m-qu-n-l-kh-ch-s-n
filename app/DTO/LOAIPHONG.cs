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
    
    public partial class LOAIPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIPHONG()
        {
            this.GIOHANGs = new HashSet<GIOHANG>();
            this.HINHLOAIPHONGs = new HashSet<HINHLOAIPHONG>();
            this.PHIEUDATPHONGs = new HashSet<PHIEUDATPHONG>();
            this.PHONGs = new HashSet<PHONG>();
        }
    
        public int ID { get; set; }
        public string TENLOAIPHONG { get; set; }
        public string MOTA { get; set; }
        public Nullable<int> SUCCHUA { get; set; }
        public Nullable<decimal> GIATHUE { get; set; }
        public string QUYDINH { get; set; }
        public string NOITHAT { get; set; }
        public string TIENICH { get; set; }
        public Nullable<bool> ISDELETED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIOHANG> GIOHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HINHLOAIPHONG> HINHLOAIPHONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONGs { get; set; }
    }
}
