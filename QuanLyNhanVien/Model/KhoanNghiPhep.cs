//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhanVien.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhoanNghiPhep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhoanNghiPhep()
        {
            this.NghiPhep = new HashSet<NghiPhep>();
        }
    
        public int Ma_KNP { get; set; }
        public int Ma_NV { get; set; }
        public int Ma_LNP { get; set; }
        public Nullable<int> SoNgayNghi_KNP { get; set; }
    
        public virtual LoaiNghiPhep LoaiNghiPhep { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NghiPhep> NghiPhep { get; set; }
    }
}
