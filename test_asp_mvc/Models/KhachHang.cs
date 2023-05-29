using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_asp_mvc.Models
{
    public class KhachHang
    {
        public int ID { set; get; }
        public string TenKhachHang { set; get; }
        public string SoDienThoai { set; get; }
        public string DiaChiNhanHang { set; get; }
        public string Email { set; get; }
        public string GioiTinh { set; get; }
        public string UrlHinhAnh { set; get; }
    }
}