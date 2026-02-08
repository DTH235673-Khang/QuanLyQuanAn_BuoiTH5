using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations.Schema;
namespace QuanLyQuanAn.Data
{
    public class ThucAn
    {
        public int ID { get; set; }
        public string TenThucAn { get; set; }
        public decimal Gia { get; set; }
        public string HinhAnh { get; set; }
        public string? MoTa { get; set; }   
        public string? TrangThai { get; set; }
        public int DanhMucID { get; set; }
        public int DonViTinhID { get; set; }
        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual DanhMuc DanhMuc { get; set; } = null!;
        public virtual DonViTinh DonViTinh { get; set; } = null!;

    }
    [NotMapped]
    public class DanhSachThucAn
    {
        public int ID { get; set; }
        public string TenThucAn { get; set; }
        public decimal Gia { get; set; }
        public string HinhAnh { get; set; }
        public string? MoTa { get; set; }
        public string? TrangThai { get; set; }

        public string TenDanhMuc { get; set; }

        public string TenDonViTinh { get;set; }
        public int DanhMucID { get; set; }
        public int DonViTinhID { get; set; }

    }
}
