using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_asp_mvc.Models;

namespace test_asp_mvc.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        public ActionResult DanhSach()
        {
            return View(DanhSachKhachHang.dsKhachHang);
        }

        public ActionResult Themmoi()
        {
            return View(new KhachHang() {ID = 0 });
        }
        [HttpPost]
        public ActionResult Themmoi(KhachHang thongsokhach, HttpPostedFileBase fileAnh)
        {
            if(thongsokhach.ID == 0)
            {
                ModelState.AddModelError("", "ID phai nhap > 0");
                return View(thongsokhach);
            }

            if(fileAnh.ContentLength > 0)
            {
                // luufile 

                // Map đến thư mục gốc mà mình tạo
                string rootFolder = Server.MapPath("/Data/");
                // lấy thư mục gốc + file ảnh
                string pathEmail = rootFolder + fileAnh.FileName;
                // lưu vào
                fileAnh.SaveAs(pathEmail);

                // luu thuoc tinh url hinhanh
                thongsokhach.UrlHinhAnh = "/Data/" + fileAnh.FileName;
            }



                DanhSachKhachHang.dsKhachHang.Add(thongsokhach);
            return RedirectToAction("DanhSach");
        }


        public ActionResult CapNhat(int idKhachHang)
        {
            // tim doi tuong can sua
            var khachHang = DanhSachKhachHang.dsKhachHang.SingleOrDefault(m => m.ID == idKhachHang);
            //truyen thong tin can sua sang view
            return View(khachHang);
        }

        [HttpPost]
        public ActionResult CapNhat(KhachHang thongtinkhachvc)
        {
            if (thongtinkhachvc.TenKhachHang == "") 
            {
                ModelState.AddModelError("", "Ban hay nhap ten vao");
                return View(thongtinkhachvc);
            }

            // tim doi tuong can sua
            var khachHang = DanhSachKhachHang.dsKhachHang.SingleOrDefault(m => m.ID == thongtinkhachvc.ID);
            //cap nhat doi tuong can sua
            khachHang.TenKhachHang = thongtinkhachvc.TenKhachHang;
            khachHang.SoDienThoai = thongtinkhachvc.SoDienThoai;
            khachHang.DiaChiNhanHang = thongtinkhachvc.DiaChiNhanHang;
            khachHang.Email = thongtinkhachvc.Email;
            khachHang.GioiTinh = thongtinkhachvc.GioiTinh;
            khachHang.UrlHinhAnh = thongtinkhachvc.UrlHinhAnh;


            return RedirectToAction("DanhSach");
        }


        public ActionResult Xoa(int idKhachHang)
        {
            // tim doi tuong can sua
            var khachHang = DanhSachKhachHang.dsKhachHang.SingleOrDefault(m => m.ID == idKhachHang);
            //truyen thong tin can sua sang view

            DanhSachKhachHang.dsKhachHang.Remove(khachHang);
            return RedirectToAction("DanhSach");
        }

    }
}