using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class ThamSoDTO
     {
          private int _soLuongKhachToiDa;
          private double? _phuThu;
          private double? _heSo;
          private decimal? _donGia;

          public int SoLuongKhachToiDa { get => _soLuongKhachToiDa; set => _soLuongKhachToiDa = value; }
          public double? PhuThu { get => _phuThu; set => _phuThu = value; }
          public double? HeSo { get => _heSo; set => _heSo = value; }
          public decimal? DonGia { get => _donGia; set => _donGia = value; }
     }
}
