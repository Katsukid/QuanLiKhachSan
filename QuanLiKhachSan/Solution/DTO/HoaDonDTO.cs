using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class HoaDonDTO
     {
          private int? _maHoaDon;
          private int? _maPhong;
          private DateTime? _ngayBatDauThue;
          private decimal? _donGia;
          private int? _soNgayDaThue;
          private int? _maPhieuThue;
          private double? _phuThu;
          private double? _heSo;
          private int? _khachPTThu;
          private string _tenKhachHang;
          private string _diaChi;
          private decimal _phiDichVu;
          private decimal? _tongTien;
          private decimal? _thanhTien;
          private DateTime _ngayThanhToan;
          private int? _soLuongKhachNuocNgoai;

          public int? MaHoaDon { get => _maHoaDon; set => _maHoaDon = value; }
          public int? MaPhong { get => _maPhong; set => _maPhong = value; }
          public DateTime? NgayBatDauThue { get => _ngayBatDauThue; set => _ngayBatDauThue = value; }
          public decimal? DonGia { get => _donGia; set => _donGia = value; }
          public int? SoNgayDaThue { get => _soNgayDaThue; set => _soNgayDaThue = value; }
          public int? MaPhieuThue { get => _maPhieuThue; set => _maPhieuThue = value; }
          public double? PhuThu { get => _phuThu; set => _phuThu = value; }
          public double? HeSo { get => _heSo; set => _heSo = value; }
          public int? KhachPTThu { get => _khachPTThu; set => _khachPTThu = value; }
          public int? SoLuongKhachNuocNgoai { get => _soLuongKhachNuocNgoai; set => _soLuongKhachNuocNgoai = value; }
          public string TenKhachHang { get => _tenKhachHang; set => _tenKhachHang = value; }
          public string DiaChi { get => _diaChi; set => _diaChi = value; }
          public decimal PhiDichVu { get => _phiDichVu; set => _phiDichVu = value; }
          public decimal? TongTien { get => _tongTien; set => _tongTien = value; }
          public decimal? ThanhTien { get => _thanhTien; set => _thanhTien = value; }
          public DateTime NgayThanhToan { get => _ngayThanhToan; set => _ngayThanhToan = value; }
     }
}
