using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class BaoCaoDoanhThuDTO
     {
          private string _tenLoaiPhong;
          private decimal? _tongDoanhThu;
          private int? _thang;
          private int? _nam;
          private string _tiLe;

          //public string MaLoaiPhong { get; set; }
          public string TenLoaiPhong { get => _tenLoaiPhong; set => _tenLoaiPhong = value; }

          public decimal? TongDoanhThu { get => _tongDoanhThu; set => _tongDoanhThu = value; }
          public int? Thang { get => _thang; set => _thang = value; }
          public int? Nam { get => _nam; set => _nam = value; }
          //public int? MaBCDoanhThu { get; set; }
          //public int? MaCTBCDoanhThu { get; set; }
          public string TiLe { get => _tiLe; set => _tiLe = value; }
     }
}
