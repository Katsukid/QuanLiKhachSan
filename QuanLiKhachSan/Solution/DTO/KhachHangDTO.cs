using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class KhachHangDTO
     {
          private string _tenKhachHang;
          private string _diaChi;
          private string _cMND;
          private string _loaiKhach;
          private string _maLoaiKhach;

          public int? MaKhachHang { get; set; }
          public string TenKhachHang { get => _tenKhachHang; set => _tenKhachHang = value; }
          public string DiaChi { get => _diaChi; set => _diaChi = value; }
          public string CMND { get => _cMND; set => _cMND = value; }
          public string LoaiKhach { get => _loaiKhach; set => _loaiKhach = value; }
          public string MaLoaiKhach { get => _maLoaiKhach; set => _maLoaiKhach = value; }
     }
}
