using CameraShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CameraShop.Controllers
{
    public class HomeController : Controller
    {
        SanPhamModels db = new SanPhamModels();
        DanhMucModels dmmd = new DanhMucModels();
        public ActionResult Index()
        {
           
            List<SanPham> listSp = db.getAllSP();
            return View(listSp);
        }
        public ActionResult ChiTietSP(int? id)
        {
            DanhMuc danhMuc;
           
            SanPham sp = db.get1sanPham(id);
            danhMuc = dmmd.get1DanhMuc(sp.MaLoai);
            ViewBag.danhMuc = danhMuc;
            List<SanPham> listSp = db.getAllSP();
            ViewBag.listSP = listSp;
            return View(sp);
        }
        public ActionResult SPtheoDanhMuc(int? id)
        {
            DanhMuc lsp;
            int count;
            List<SanPham> listSp;
            List<DanhMuc> list = dmmd.getAllDanhMuc();
            if (id == null)
            {
                listSp = db.getAllSP();
            }
            else
            {
                lsp = dmmd.get1DanhMuc(id);
                listSp = db.getSPbyDanhMuc(id);
                var tenlsp = lsp.TenLoai;
                ViewBag.LoaiSP = lsp;
                ViewBag.tenLoai = tenlsp;
            }
            count = listSp.Count;
            ViewBag.count = count;

            return View(listSp);
        }
    }
}