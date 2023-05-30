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



        public ActionResult ChiTietDonHang (int idDonHang)
        {
            var donHang = StaticDonHang.DanhSachDonHang.SingleOrDefault(m => m.ID == idDonHang);
            return View(donHang);
        }

        public ActionResult ThemChiTiet(int idDonHang)
        {
            ViewBag.idDonHang = idDonHang;

            return View(new MayTinh());
        }
        [HttpPost]
        public ActionResult ThemChiTiet(MayTinh chitiet, int idDonHang)
        {
            var donHang = StaticDonHang.DanhSachDonHang.SingleOrDefault(m => m.ID == idDonHang);
            donHang.MayTinhDatMua.Add(chitiet);
            return RedirectToAction("ChiTietDonHang" , new { idDonHang = idDonHang});
        }

        public ActionResult CapNhatChiTiet(int idDonHang, string maMay)
        {
            ViewBag.idDonHang = idDonHang;
            var donHang = StaticDonHang.DanhSachDonHang.SingleOrDefault(m => m.ID == idDonHang);
            var mayTinhCanSua = donHang.MayTinhDatMua.SingleOrDefault(m => m.MaMay == maMay);
            return View(mayTinhCanSua);
        }

        [HttpPost]
        public ActionResult CapNhatChiTiet(MayTinh chitiet, int idDonHang)
        {
            var donHang = StaticDonHang.DanhSachDonHang.SingleOrDefault(m => m.ID == idDonHang);
            var mayTinhCanSua = donHang.MayTinhDatMua.SingleOrDefault(m => m.MaMay == chitiet.MaMay);
            mayTinhCanSua.DongMay = chitiet.DongMay;
            mayTinhCanSua.GiaBan = chitiet.GiaBan;
            mayTinhCanSua.NgaySanXuat = chitiet.NgaySanXuat;
            mayTinhCanSua.HangSanXuat = chitiet.HangSanXuat;
            return RedirectToAction("ChiTietDonHang", new { idDonHang = idDonHang });
        }

        public ActionResult XoaChiTiet(int idDonHang, string maMay)
        {
            var donHang = StaticDonHang.DanhSachDonHang.SingleOrDefault(m => m.ID == idDonHang);
            var mayTinhCanSua = donHang.MayTinhDatMua.SingleOrDefault(m => m.MaMay == maMay);
            donHang.MayTinhDatMua.Remove(mayTinhCanSua);
            return RedirectToAction("ChiTietDonHang", new { idDonHang = idDonHang });
        }


    }
}