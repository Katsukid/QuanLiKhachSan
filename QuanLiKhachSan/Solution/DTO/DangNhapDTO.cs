using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class DangNhapDTO
     {
          private int _maDangNhap;
          private string _tenDangNhap;
          private string _matKhau;

          public int MaDangNhap { get => _maDangNhap; set => _maDangNhap = value; }
          public string TenDangNhap { get => _tenDangNhap; set => _tenDangNhap = value; }
          public string MatKhau { get => _matKhau; set => _matKhau = value; }
     }
}
