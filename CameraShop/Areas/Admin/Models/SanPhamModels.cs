using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CameraShop.Areas.Admin.Models
{
    public class SanPhamModels
    {
        DBModels dbsp = new DBModels();

        public List<SanPham> getAllSP()
        {
            DataTable dt = dbsp.readData("SELECT * FROM SanPham");
            List<SanPham> listSp = new List<SanPham>();
            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham();
                sp.MaSP = int.Parse(dr[0].ToString());
                sp.TenSP = dr[1].ToString();
                sp.MoTa = dr[2].ToString();
                sp.DonGia = int.Parse(dr[3].ToString());
                sp.SoLuong = int.Parse(dr[4].ToString());
                sp.MaLoai = int.Parse(dr[5].ToString());
                sp.Anh = dr[6].ToString();

                listSp.Add(sp);
            }
            return listSp;
        }
        public List<SanPham> getSPbyDanhMuc(int? id)
        {
            DataTable dt = dbsp.readData("SELECT * FROM SanPham WHERE MaLoai = '" + id + "'");
            List<SanPham> listSp = new List<SanPham>();
            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham();
                sp.MaSP = int.Parse(dr[0].ToString());
                sp.TenSP = dr[1].ToString();
                sp.MoTa = dr[2].ToString();
                sp.DonGia = int.Parse(dr[3].ToString());
                sp.SoLuong = int.Parse(dr[4].ToString());
                sp.MaLoai = int.Parse(dr[5].ToString());
                sp.Anh = dr[6].ToString();
                listSp.Add(sp);
            }
            return listSp;
        }

    }
}