using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThongTinDienTu
{
    public partial class TrangKeHoach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public string showKH()
        {
            List<ThongTinTinTuc> kh = new List<ThongTinTinTuc>();
            StringBuilder sb = new StringBuilder();
            kh = (List<ThongTinTinTuc>)Application["KeHoach"];
            foreach (ThongTinTinTuc i in kh)
            {
                sb.Append("<div class='tom_tat'>");

                sb.Append("<div>");
                sb.Append("<div class ='img_anh'>");
                sb.AppendFormat("<img src = 'images/{0}' alt='{1}, title='{1}'/>", i.ImageFile, i.Tieude);
                sb.Append("</div>");
                sb.Append("</div>");

                sb.Append("<div>");
                sb.AppendFormat("<div class='tin_tilte'><a href = 'Tranconchitiet.aspx?id={0}' title='tintuc'>{1}</a></div><div class='tintic_abstract'>{2}</div><p style = 'float: right;'><a href= '/Tranconchitiet.aspx?id={0}' style= 'font-style:italic;' > Xem chi tiết</a></p>"
                    , i.Id
                    , i.Tieude
                    , i.GT
                    , i.Idtype);
                sb.Append("</div>");

                sb.Append("</div>");
            }
            
            return sb.ToString();
        }
        /*<div class="tom_tat">
                <div>
                    <div class ="img_anh">
                        <img src = "images/FITHOU.jpg" alt="Alternate Text"/>
                    </div>
                </div>
                <div>
                    <div class="tin_tilte">
                        <a href = "#" > Trường Đại học Mở Hà Nội công bố Đề án tuyển sinh năm 2022</a>
                    </div>
                    <div class="tintic_abstract">
                        " Theo Đề án tuyển sinh năm 2022, Trường Đại học Mở Hà Nội tuyển sinh đại học các hệ Chính quy, Vừa làm vừa học, Từ xa, Văn bằng hai chính quy, Liên thông đại học chính quy, song bằng, Liên kết quốc tế. Cùng với đó, Trường tuyển sinh 7 ngành của trình độ thạc sĩ và ngành Ngôn ngữ Anh ở trình độ Tiến sĩ.
                        Đối với đại học hệ chính quy, Trường Đại học Mở Hà Nội tuyển sinh 18 ngành với 3.600 chỉ tiêu.Trường dành 3.270 chỉ tiêu xét tuyển sử dụng kết quả thi tốt nghiệp THPT, 250 chỉ tiêu xét tuyển học bạ và 80 chỉ tiêu xét kết quả bài thi đánh giá năng lực do ĐH Quốc gia Hà Nội tổ chức."
                    </div>
                    <p style = "float: right;" >
                        < a href= "#" style= "font-style:italic;" > Xem chi tiết</a>
                    </p>
                </div>*/


    }
}