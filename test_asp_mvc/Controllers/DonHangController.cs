using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_asp_mvc.Models;

namespace test_asp_mvc.Controllers
{
    public class DonHangController : Controller
    {
        // GET: DonHang
        public ActionResult DanhSach()
        {
            return View(StaticDonHang.DanhSachDonHang);
        }

        public ActionResult ThemMoiDonHang()
        {
            return View(new DonHang() { ID = 0});
        }
        [HttpPost]
        public ActionResult ThemMoiDonHang(DonHang thongtinkhach)
        {
            if(thongtinkhach.ID == 0)
            {
                ModelState.AddModelError("", "ID phai nhap > 0");
                return View(thongtinkhach);
            }

            StaticDonHang.DanhSachDonHang.Add(thongtinkhach);
            return RedirectToAction("DanhSach");
        }


        public ActionResult CapNhat(int idDonHang)
        {
            var donHang = StaticDonHang.DanhSachDonHang.SingleOrDefault(m => m.ID == idDonHang);
            return View(donHang);
        }

        [HttpPost]
        public ActionResult CapNhat(DonHang thongtindonhang)
        {
            if (thongtindonhang.TenKhachHang == "")
            {
                ModelState.AddModelError("", "Ban phai nhap ten nhe");
                return View(thongtindonhang);
            }

            // tim doi tuong can update
            var donHang = StaticDonHang.DanhSachDonHang.SingleOrDefault(m => m.ID == thongtindonhang.ID);
            donHang.TenKhachHang = thongtindonhang.TenKhachHang;
            donHang.SoDienThoai = thongtindonhang.SoDienThoai;
            donHang.DiaChiGiaoHang = thongtindonhang.DiaChiGiaoHang;
            donHang.NgayDatHang = thongtindonhang.NgayDatHang;

            return RedirectToAction("DanhSach");
        }

        public ActionResult Xoa(int idDonHang)
        {
            var donHang = StaticDonHang.DanhSachDonHang.SingleOrDefault(m => m.ID == idDonHang);
            StaticDonHang.DanhSachDonHang.Remove(donHang);
            return RedirectToAction("DanhSach");
        }
    }
}