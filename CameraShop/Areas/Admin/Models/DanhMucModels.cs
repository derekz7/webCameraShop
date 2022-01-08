using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CameraShop.Areas.Admin.Models
{
    public class DanhMucModels
    {
        DBModels dbsp = new DBModels();

        public List<DanhMuc> getAllDanhMuc()
        {
            DataTable dt = dbsp.readData("SELECT * FROM DanhMuc");
            List<DanhMuc> listDanhMuc = new List<DanhMuc>();
            foreach (DataRow dr in dt.Rows)
            {
                DanhMuc danhMuc = new DanhMuc();
                danhMuc.MaLoai = int.Parse(dr[0].ToString());
                danhMuc.TenLoai = dr[1].ToString();
                danhMuc.GhiChu = dr[2].ToString();
                danhMuc.Anh = dr[3].ToString();
                listDanhMuc.Add(danhMuc);
            }
            return listDanhMuc;
        }
        public DanhMuc get1DanhMuc(int? id)
        {
            DataTable dt = dbsp.readData("SELECT * FROM DanhMuc WHERE MaLoai = '" + id + "'");
            DanhMuc danhMuc = new DanhMuc();
            danhMuc.MaLoai = int.Parse(dt.Rows[0][0].ToString());
            danhMuc.TenLoai = dt.Rows[0][1].ToString();
            danhMuc.GhiChu = dt.Rows[0][2].ToString();
            danhMuc.Anh = dt.Rows[0][3].ToString();
            return danhMuc;
        }
    }
}