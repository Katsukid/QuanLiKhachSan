using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class PhieuThuePhongDTO
     {
          private int? _maPhong;
          private DateTime _ngayThue;
          private int? _maPhieuThue;
          private int? _maChiTietPhieuThue;
          private DateTime? _ngayTraPhong;

          public int? MaPhong { get => _maPhong; set => _maPhong = value; }
          public DateTime NgayThue { get => _ngayThue; set => _ngayThue = value; }
          public int? MaPhieuThue { get => _maPhieuThue; set => _maPhieuThue = value; }
          public int? MaChiTietPhieuThue { get => _maChiTietPhieuThue; set => _maChiTietPhieuThue = value; }
          public DateTime? NgayTraPhong { get => _ngayTraPhong; set => _ngayTraPhong = value; }
     }
}
