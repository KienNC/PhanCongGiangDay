//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhanCongGiangDay.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class SinhVienDK
    {
        public int Id { get; set; }
        public int SinhVienId { get; set; }
        public int GiangVienId { get; set; }
        public int HocPhanId { get; set; }
        public System.DateTime ThoiGian { get; set; }
        public string DinhHuong { get; set; }
        public string KyHoc { get; set; }
    
        public virtual GiangVien GiangVien { get; set; }
        public virtual HocPhan HocPhan { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
