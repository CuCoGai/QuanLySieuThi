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
    
    public partial class ChiTietXuat
    {
        public int MaPhieu { get; set; }
        public int MaHang { get; set; }
        public Nullable<long> SoLuong { get; set; }
        public Nullable<decimal> GiaXuat { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual HangHoa HangHoa { get; set; }
        public virtual PhieuXuat PhieuXuat { get; set; }
    }
}
