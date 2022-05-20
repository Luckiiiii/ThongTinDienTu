using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThongTinDienTu
{
    public partial class TrangDaoTao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string showDT()
        {
            List<ThongTinTinTuc> kh = new List<ThongTinTinTuc>();
            StringBuilder sb = new StringBuilder();
            kh = (List<ThongTinTinTuc>)Application["DaoTao"];
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
    }
}