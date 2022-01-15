using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CameraShop.Models;

namespace CameraShop.Controllers
{
    public class CartController : Controller
    {
        public DBContext db = new DBContext();
        // GET: GioHang
        public Cart getCart() {
            Cart gioHang = Session["Cart"] as Cart;
            if (gioHang == null || Session["Cart"] == null)
            {
                gioHang = new Cart();
                Session["Cart"] = gioHang;
            }
            return gioHang;
        }

        //add item vao gio hang
        public ActionResult AddtoCart(int? id)
        {
            var product = db.SanPham.SingleOrDefault(s => s.MaSP == id);
            if (product != null)
            {
                getCart().Add(product); 
            }
            return RedirectToAction("ShowCart", "Cart");
        }

        //trang gio hang
        public ActionResult ShowCart()
        {
            if (Session["Cart"] == null)
                return RedirectToAction("ShowCart", "Cart");
            Cart gioHang = Session["Cart"] as Cart;
            return View(gioHang);

        }
        public ActionResult delete_SP(int id)
        {
            Cart gioHang = Session["Cart"] as Cart;
            gioHang.delete_SP_Shopping(id);
            return RedirectToAction("ShowCart", "Cart");
        }


    }
}