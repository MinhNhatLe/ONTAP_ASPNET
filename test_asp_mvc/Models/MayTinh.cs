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
            List<MayTinh> danhSachMayTinh = new List<MayTinh>();


            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "0000001",
                DongMay = "Asus 01",
                GiaBan = 100000,
                NgaySanXuat = new DateTime(2022, 1, 1),
                HangSanXuat = "Asus1",
            });
            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "0000002",
                DongMay = "Asus 02",
                GiaBan = 200000,
                NgaySanXuat = new DateTime(2022, 1, 1),
                HangSanXuat = "Asus2",
            });
            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "0000003",
                DongMay = "Asus 03",
                GiaBan = 300000,
                NgaySanXuat = new DateTime(2022, 1, 1),
                HangSanXuat = "Asus3",
            });
            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "0000004",
                DongMay = "Asus 04",
                GiaBan = 400000,
                NgaySanXuat = new DateTime(2022, 1, 1),
                HangSanXuat = "Asus4",
            });
            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "0000005",
                DongMay = "Asus 05",
                GiaBan = 500000,
                NgaySanXuat = new DateTime(2022, 1, 1),
                HangSanXuat = "Asus5",
            });

            return danhSachMayTinh;
        }

    }
}