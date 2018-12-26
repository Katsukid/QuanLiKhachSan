using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class OderDichVuDTO
     {
          private int _maPhong;
          private int _maDichVu;
          private string _tenDichVu;
          private int _soLuong;

          public int MaPhong { get => _maPhong; set => _maPhong = value; }
          public int MaDichVu { get => _maDichVu; set => _maDichVu = value; }
          public string TenDichVu { get => _tenDichVu; set => _tenDichVu = value; }
          public int SoLuong { get => _soLuong; set => _soLuong = value; }
     }
}
