//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySieuThi.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HangHoa
    {
        public HangHoa()
        {
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            this.ChiTietNhaps = new HashSet<ChiTietNhap>();
            this.ChiTietXuats = new HashSet<ChiTietXuat>();
        }
    
        public int MaLoai { get; set; }
        public int MaHang { get; set; }
        public string TenHang { get; set; }
        public string DonViTinh { get; set; }
        public string TenNhaSanXuat { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> NgaySx { get; set; }
        public Nullable<System.DateTime> HanSd { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual ICollection<ChiTietNhap> ChiTietNhaps { get; set; }
        public virtual ICollection<ChiTietXuat> ChiTietXuats { get; set; }
        public virtual LoaiHang LoaiHang { get; set; }
    }
}
