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

        public ActionResult ThemMoi()
        {
            return View(new KhachHang() {ID = 0 });
        }
        [HttpPost]
        public ActionResult Themmoi(KhachHang thongsokhach)
        {
            if(thongsokhach.ID == 0)
            {
                ModelState.AddModelError("", "ID phai nhap > 0");
                return View(thongsokhach);
            }
                DanhSachKhachHang.dsKhachHang.Add(thongsokhach);
            return RedirectToAction("DanhSach");
        }

    }
}