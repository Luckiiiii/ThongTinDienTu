using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThongTinDienTu
{
    public partial class timkiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["search"] != "")
            {
                string keySearch = Request.QueryString["search"];
                List<ThongTinTinTuc> listTT;
                var html = "";
                listTT = (List<ThongTinTinTuc>)Application["ALL"];
                foreach (ThongTinTinTuc p in listTT)
                {
                    if (p.Tieude.ToLower().Contains(keySearch.ToLower()))
                    {

                        html += "<div>";

                       /* html += "<div class='img'>";
                        html += "<a href='Tranconchitiet.aspx?id=" + p.Id + "'>";
                        html += "<img src='" + p.ImageFile + "' alt='' style='height: 200px;width: 76 %;margin - left: 24px;'/>";
                        html += "</a>";
                        html += "</div>";*/

                        html += "<div class='nuochoanam-infor'>";
                        html += "<a href='Tranconchitiet.aspx?id=" + p.Id + "'>";
                        html += "<h3 class='line-clamp'>" + p.Tieude + "</h3>";

                        html += "</a>";
                        html += "<div class='nuochoanam-price' style='font-size: 14px; line-height: 1.1; font-weight: 600; color: #07053d;'></div>";
                        html += "</div>";

                        html += "</div>";
                    }
                }
                contentSearch.InnerHtml = html;
            }
        }
    }
    
}
/*Lấy chiều dài chuỗi C#
 str.Length
So sánh 2 chuỗi C#
String.Compare(str1, str2, true)
Kiểm tra sự tồn tại của chuỗi 1 (Str1) trong chuỗi 2 (Str2) 
Str2.Contains(Str1)
Tìm vị trí hiển thị của chuỗi C#
Str1.IndexOf("chuỗi")
Tìm vị trí xuất hiện cuối cùng của chuỗi C#
Str1.LastIndexOf("chuỗi")
Kiểm tra xem chuỗi 1 (Str1) có bắt bầu bằng ký tự trong chuỗi 2 (Str2) không
Str1.StartsWith(Str2)
Thay thế chuỗi C#
Str = Str.Replace(",",".")
Cắt chuỗi con C#
Str1 = Str.SubString(2)
Tách chuỗi C#
.Split
Xóa khoảng trắng
Str = Str.Trim()
Cắt hết khoảng trắng ở đầu và cuối chuỗi

Str = Str.TrimLeft()
Cắt hết khoảng trắng ở đầu chuỗi

Str = Str.TrimRight()
Cắt hết khoảng trắng ở cuối chuỗi
Xóa chuỗi C#
Str1.Remove(1)*/
