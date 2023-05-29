using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_asp_mvc.Models
{
    public class MayTinh
    {
        public string MaMay { set; get; }
        public string DongMay { set; get; }
        public double GiaBan { set; get; }
        public DateTime NgaySanXuat { set; get; }
        public string HangSanXuat { set; get; }

        public List<MayTinh> KhoiTao5May() 
        {
            // lấy danh sách MayTinh và đặt ten thành danhSachMayTinh
            List<MayTinh> danhSachMayTinh = new List<MayTinh>();

            // Add data vào MayTinh
            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "0000001",
                DongMay = "chán đời",
                GiaBan = 100000,
                NgaySanXuat = new DateTime(2022, 1, 1),
                HangSanXuat = "Asus",
            });
            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "0000002",
                DongMay = "nát",
                GiaBan = 200000,
                NgaySanXuat = new DateTime(2022, 1, 1),
                HangSanXuat = "Dell",
            });
            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "0000003",
                DongMay = "lỏ chày",
                GiaBan = 300000,
                NgaySanXuat = new DateTime(2022, 1, 1),
                HangSanXuat = "Asus",
            });
            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "0000004",
                DongMay = "dòng tào lao",
                GiaBan = 400000,
                NgaySanXuat = new DateTime(2022, 1, 1),
                HangSanXuat = "Toshiba",
            });
            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "0000005",
                DongMay = "tùm lum",
                GiaBan = 500000,
                NgaySanXuat = new DateTime(2022, 1, 1),
                HangSanXuat = "Acer",
            });

            return danhSachMayTinh;
        }

    }
}