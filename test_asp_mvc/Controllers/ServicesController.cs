using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_asp_mvc.Models;

namespace test_asp_mvc.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Services()
        {

            return View(DanhSachMayTinh.listMayTinh);
        }

        
        public ActionResult Them()
        {
            return View();
        }

        // cách 1 khai báo kiểu dữ liệu và tên. cách này lâu la
        // rồi add vào
        [HttpPost]
        public ActionResult LuuSanPham(string maMay, string dongMay, double giaBan, DateTime ngaySanXuat, string hangSanXuat)
        {
            DanhSachMayTinh.listMayTinh.Add(new MayTinh()
            {
                MaMay = maMay,
                DongMay = dongMay,
                GiaBan = giaBan,
                NgaySanXuat = ngaySanXuat,
                HangSanXuat = hangSanXuat,
            });
            return RedirectToAction("Services");
        }


        public ActionResult Them2()
        {
            return View(new MayTinh() { GiaBan = 0, NgaySanXuat = DateTime.Now});
        }

        // mình ấy class vào rồi đặt tên gì cũng đượcs
        [HttpPost]
        public ActionResult Them2(MayTinh thongso)
        {
            // cách này cx lâu qá trời
            //DanhSachMayTinh.listMayTinh.Add(new MayTinh()
            //{

            //    MaMay = thongso.MaMay,
            //    DongMay = thongso.DongMay,
            //    GiaBan = thongso.GiaBan,
            //    NgaySanXuat = thongso.NgaySanXuat,
            //    HangSanXuat = thongso.HangSanXuat,
            //});


            // cách này nhanh vcl
            DanhSachMayTinh.listMayTinh.Add(thongso);
            return RedirectToAction("Services");
        }
    }
}