using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class InHoaDonDTO
     {
          private int _maHoaDon;
          private int _maPhong;
          private decimal _donGia;
          private int _soNgayThue;
          private string _tenKhachHang;
          private decimal _thanhTien;

          public int MaHoaDon { get => _maHoaDon; set => _maHoaDon = value; }
          public int MaPhong { get => _maPhong; set => _maPhong = value; }
          public decimal DonGia { get => _donGia; set => _donGia = value; }
          public int SoNgayThue { get => _soNgayThue; set => _soNgayThue = value; }
          public string TenKhachHang { get => _tenKhachHang; set => _tenKhachHang = value; }
          public decimal ThanhTien { get => _thanhTien; set => _thanhTien = value; }

     }
}
