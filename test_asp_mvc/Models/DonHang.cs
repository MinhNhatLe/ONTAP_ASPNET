using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_asp_mvc.Models
{
    public class DonHang
    {
        public int ID { set; get; }
        public string TenKhachHang { set; get; }
        public string SoDienThoai { set; get; }
        public string DiaChiGiaoHang { set; get; }
        public DateTime NgayDatHang { set; get; }
        public List<MayTinh> MayTinhDatMua = new List<MayTinh>();
    }
}