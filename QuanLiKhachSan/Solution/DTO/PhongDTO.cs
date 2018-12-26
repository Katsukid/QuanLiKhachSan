using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class PhongDTO
     {
          private int? _maPhong;
          private string _tinhTrang;
          private string _maLoaiPhong;
          private string _tenLoaiPhong;
          private string _ghiChu;
          private decimal? _donGia;
          private DateTime? _ngayTraPhongDuKien;

          public int? MaPhong { get => _maPhong; set => _maPhong = value; }
          public string TinhTrang { get => _tinhTrang; set => _tinhTrang = value; }
          public string MaLoaiPhong { get => _maLoaiPhong; set => _maLoaiPhong = value; }
          public string TenLoaiPhong { get => _tenLoaiPhong; set => _tenLoaiPhong = value; }
          public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
          public decimal? DonGia { get => _donGia; set => _donGia = value; }
          public DateTime? NgayTraPhongDuKien { get => _ngayTraPhongDuKien; set => _ngayTraPhongDuKien = value; }
     }
}
