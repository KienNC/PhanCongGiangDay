﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PhanCongGiangDayEntities : DbContext
    {
        public PhanCongGiangDayEntities()
            : base("name=PhanCongGiangDayEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChucNang> ChucNangs { get; set; }
        public virtual DbSet<DmBoMon> DmBoMons { get; set; }
        public virtual DbSet<DmChuongTrinh> DmChuongTrinhs { get; set; }
        public virtual DbSet<DmGiangVien> DmGiangViens { get; set; }
        public virtual DbSet<DmHocPhan> DmHocPhans { get; set; }
        public virtual DbSet<GiangVienDay> GiangVienDays { get; set; }
        public virtual DbSet<GiangVienDK> GiangVienDKs { get; set; }
        public virtual DbSet<KhoiLuongPhanCong> KhoiLuongPhanCongs { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<NhatKyHeTHong> NhatKyHeTHongs { get; set; }
        public virtual DbSet<PhanCong> PhanCongs { get; set; }
        public virtual DbSet<PhanCongDA> PhanCongDAs { get; set; }
        public virtual DbSet<QLNguoiDung> QLNguoiDungs { get; set; }
        public virtual DbSet<QLNguoiDungVaiTro> QLNguoiDungVaiTroes { get; set; }
        public virtual DbSet<QLQuyen> QLQuyens { get; set; }
        public virtual DbSet<QLVaiTro> QLVaiTroes { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<SinhVienDA> SinhVienDAs { get; set; }
        public virtual DbSet<SinhVienDK> SinhVienDKs { get; set; }
        public virtual DbSet<ThoiGianLopHoc> ThoiGianLopHocs { get; set; }
        public virtual DbSet<TrangThaiGiangVien> TrangThaiGiangViens { get; set; }
        public virtual DbSet<QLVaiTroQuyen> QLVaiTroQuyens { get; set; }
    }
}
