using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThongTinDienTu
{
    public partial class DangXuat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Session.Remove("name");
            Session.Abandon();
            Response.Redirect("DangNhap.aspx");
            /*if (Session["login_time"] != null)
            {
                DateTime loginTime = (DateTime)Session["login_time"];
                var loginTimeDurationInMinutes = (DateTime.Now - loginTime).Seconds;

                tg.InnerHtml = Session["email"].ToString() + ": " + loginTimeDurationInMinutes;
            }*/

        }
    }
}