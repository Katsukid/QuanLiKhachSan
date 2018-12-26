using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class PhieuThueDAO
    {
        static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();
        public static List<KhachHangDTO> LayMaKHKeTiep()
        {
            var query = (from k in context.KHACH_HANG
                         select new KhachHangDTO
                         {
                             MaKhachHang = k.MaKhachHang,
                         }).OrderByDescending(x => x.MaKhachHang).Take(1);
            return query.ToList();
        }

        public static List<PhieuThuePhongDTO> LayMaCTPTKeTiep()
        {
            var query = (from ctpt in context.CHI_TIET_PHIEU_THUE
                         select new PhieuThuePhongDTO
                         {
                             MaChiTietPhieuThue = ctpt.MaChiTietPT,
                         }).OrderByDescending(x => x.MaChiTietPhieuThue).Take(1);
            return query.ToList();
        }

        public static List<PhieuThuePhongDTO> LayPhongTuongUng(int makh)
        {
            var query = (from pt in context.PHIEU_THUE_PHONG
                         join ct in context.CHI_TIET_PHIEU_THUE on pt.MaPhieuThue equals ct.MaPhieuThue
                         where ct.MaKhachHang == makh
                         select new PhieuThuePhongDTO
                         {
                             MaPhong = pt.MaPhong,
                         });
            return query.ToList();
        }

        public static bool ThemCTPhieuThuePhong(ChiTietPhieuThueDTO ct, KhachHangDTO kh)
        {
            SqlParameter mactpt = new SqlParameter("@MaCTPT", ct.MaChiTietPhieuThue);
            SqlParameter makh = new SqlParameter("@MaKH", kh.MaKhachHang);
            SqlParameter mapt = new SqlParameter("@MaPT", ct.MaPhieuThue);
            try
            {
                context.Database.ExecuteSqlCommand("spThemCTPhieuThue @MaCTPT, @MaKH, @MaPT", mactpt, makh, mapt);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ThemPhieuThuePhong(ChiTietPhieuThueDTO ct, PhieuThuePhongDTO p)
        {
            SqlParameter mapt = new SqlParameter("@MaPT", ct.MaPhieuThue);
            SqlParameter ngaythue = new SqlParameter("@NgayThue", p.NgayThue);
            SqlParameter maphong = new SqlParameter("@MaPhong", p.MaPhong);
            SqlParameter ngaytraphong = new SqlParameter("@NgayTraPhong", p.NgayTraPhong);
            try
            {
                context.Database.ExecuteSqlCommand("spThemPhieuThue @MaPT , @NgayThue , @MaPhong , @NgayTraPhong", mapt, ngaythue, maphong, ngaytraphong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<PhieuThuePhongDTO> LayMaPTKeTiep()
        {
            var query = (from pt in context.PHIEU_THUE_PHONG
                         select new PhieuThuePhongDTO
                         {
                             MaPhieuThue = pt.MaPhieuThue,
                         }).OrderByDescending(x => x.MaPhieuThue).Take(1);
            return query.ToList();
        }
    }
}
