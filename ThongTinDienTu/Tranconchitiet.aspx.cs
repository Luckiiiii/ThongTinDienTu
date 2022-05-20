using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThongTinDienTu
{
    public partial class Tranconchitiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string request = Request.QueryString["id"];
            var typeTinTuc = double.Parse(request);
            List<ThongTinTinTuc> thongTin = new List<ThongTinTinTuc>();
            if (typeTinTuc >= 1 &&typeTinTuc < 2)
            {
                thongTin = (List<ThongTinTinTuc>)Application["DaoTao"];
            }
            if (typeTinTuc >= 2 && typeTinTuc < 3)
            {
                thongTin = (List<ThongTinTinTuc>)Application["TuyenSinh"];
            }
            if (typeTinTuc >= 3 && typeTinTuc < 4)
            {
                thongTin = (List<ThongTinTinTuc>)Application["HoatDong"];
            }
            if (typeTinTuc >= 4 && typeTinTuc < 5)
            {
                thongTin = (List<ThongTinTinTuc>)Application["KeHoach"];
            }

            foreach (ThongTinTinTuc thong in thongTin)
            {
                if (thong.Id == request)
                {
                    title.InnerText = thong.Tieude;
                    noiDung.InnerText = thong.Noidung;
                    //anh.InnerHtml = "<img src='images/" + thong.ImageFile+"' alt='Alternate Text' title='aaaa'/>";
                }
            }

        }
    }
}