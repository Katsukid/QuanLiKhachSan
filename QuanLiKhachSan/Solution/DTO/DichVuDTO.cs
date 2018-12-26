using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class DichVuDTO
     {
          private int _maDichVu;
          private string _tenDichVu;
          private string _donViTinh;
          private decimal _donGia;

          public int MaDichVu { get => _maDichVu; set => _maDichVu = value; }
          public string TenDichVu { get => _tenDichVu; set => _tenDichVu = value; }
          public string DonViTinh { get => _donViTinh; set => _donViTinh = value; }
          public decimal DonGia { get => _donGia; set => _donGia = value; }
     }
}
