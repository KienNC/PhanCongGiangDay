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
    
    public partial class GiangVienDK
    {
        public int Id { get; set; }
        public int GiangVienId { get; set; }
        public int SinhVienId { get; set; }
        public int HocPhanId { get; set; }
        public string KyHoc { get; set; }
    
        public virtual DmGiangVien DmGiangVien { get; set; }
        public virtual DmHocPhan DmHocPhan { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
