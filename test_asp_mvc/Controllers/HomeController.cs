using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_asp_mvc.Helper;
using test_asp_mvc.Models;

namespace test_asp_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // cách 1 truyền bằng viewbag
            int a = 10;
            ViewBag.A = a;


            // cách 2 truyền bằng viewbag
            ViewBag.B = TinhTong(5,100);

            // cách 3 truyền bằng viewbag
            ViewBag.C = new MathHelper().TinhHieu(100, 50);

            // cách 4 truyền thẳng cho view
            //return View(10);


            // cách 5 & 6 tạo từ class ra 
            //khai báo mảng danh sách
            List<clsSinhVien> dsSinhVien = new List<clsSinhVien>();
            //khai báo đối tượng 1
            var sv1 = new clsSinhVien();
            sv1.ID = 1;
            sv1.MaSo = "sv001";
            sv1.HoTen = "Nhat Le";
            sv1.Lop = "12";
            dsSinhVien.Add(sv1);

            //khai báo đối tượng 2
            var sv2 = new clsSinhVien();
            sv2.ID = 2;
            sv2.MaSo = "sv002";
            sv2.HoTen = "Dan Vo";
            sv2.Lop = "11";
            dsSinhVien.Add(sv2);



            // truyền danh sách vào view
            return View(dsSinhVien);
        }

        public int TinhTong(int b, int c)
        {
            return b + c;
        }

    }
}