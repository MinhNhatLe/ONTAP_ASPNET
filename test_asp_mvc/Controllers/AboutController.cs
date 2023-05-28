using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_asp_mvc.Models;

namespace test_asp_mvc.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult About()
        {
            var ds5May = new MayTinh().KhoiTao5May();
            return View(ds5May);
        }

        // danh sách 2 máy thấp giá nhất
        public ActionResult HaiMayGiaThapNhat()
        {
            // sử dụng OderBy để sắp xếp
            // take lấy 2
            var ds2May = new MayTinh().KhoiTao5May().OrderBy(m => m.GiaBan).Take(2).ToList();
            return View(ds2May);
        }

        // danh sách 2 máy cao giá nhất
        public ActionResult HaiMayGiaCaoNhat()
        {
            // sử dụng OderBy để sắp xếp
            // take lấy 2
            var ds2May = new MayTinh().KhoiTao5May().OrderByDescending(m => m.GiaBan).Take(2).ToList();
            return View(ds2May);
        }

        // danh sách các máy giảm dần giá tiền
        public ActionResult SapXepGiamDan()
        {
            // sử dụng OderBy để sắp xếp
            // take lấy 2
            var dsMay = new MayTinh().KhoiTao5May().OrderByDescending(m => m.GiaBan).ToList();
            return View(dsMay);
        }

        // danh sách các máy dòng Asus
        public ActionResult HangAsus()
        {
            // sử dụng OderBy để sắp xếp
            // take lấy 2
            var dsMayAsus = new MayTinh().KhoiTao5May().Where(m => m.HangSanXuat == "Asus").ToList();
            return View(dsMayAsus);
        }
    }
}