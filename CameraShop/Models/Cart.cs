using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CameraShop.Models
{
    public class ItemCart
    {
        public int Id { get; set; }
        public SanPham sanPham_shopping { get; set; }
        public int soLuong_shopping { get; set; }

    }
    public class Cart

    {
        List<ItemCart> itemGioHangs = new List<ItemCart>();
        public IEnumerable<ItemCart> ItemGioHangs
        {
            get { return itemGioHangs; }
        }
        public void Add(SanPham sanPham, int soLuong = 1)
        {
            var item = itemGioHangs.FirstOrDefault(s => s.sanPham_shopping.MaSP == sanPham.MaSP);
            if (item == null)
            {
                itemGioHangs.Add(new ItemCart
                {
                    sanPham_shopping = sanPham,
                    soLuong_shopping = soLuong
                });

            }
            else
            {
                item.soLuong_shopping += soLuong;
            }
        }
        public void Update_SL_Shopping(int ? id, int soLuong)
        {
            var item = itemGioHangs.Find(s => s.sanPham_shopping.MaSP == id);
            if (item != null)
            {
                item.soLuong_shopping = soLuong;
            }
        }

        public void delete_SP_Shopping(int id)
        {
            var item = itemGioHangs.Find(s => s.Id == id);
            if (item != null)
            {
                itemGioHangs.Remove(item);
            }
        }
    }
}