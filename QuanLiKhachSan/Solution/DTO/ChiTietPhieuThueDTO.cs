using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class ChiTietPhieuThueDTO
     {
          private int? _maChiTietPhieuThue;
          private int? _maKhachHang;
          private int? _maPhieuThue;

          public int? MaChiTietPhieuThue { get => _maChiTietPhieuThue; set => _maChiTietPhieuThue = value; }
          public int? MaKhachHang { get => _maKhachHang; set => _maKhachHang = value; }
          public int? MaPhieuThue { get => _maPhieuThue; set => _maPhieuThue = value; }
     }
}
