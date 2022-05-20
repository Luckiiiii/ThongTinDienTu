using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThongTinDienTu
{
    public partial class DangKi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<classUser> danhsach;
            danhsach = (List<classUser>)Application["user"];
            string email = Request.Form["email"];
            string hoten = Request.Form["hoten"];
            string pass = Request.Form["pass"];
            if (IsPostBack)
            {
                if (Request.Form["dangky"] == "Đăng ký")
                {
                    classUser us = new classUser(email, hoten,pass);
                    us.Email = email;
                    us.HoTen = hoten;
                    us.Pass = pass;
                    danhsach.Add(us);
                    Application["user"] = danhsach;
                    Session["dangnhap"] = 1;
                    Session["email"] = email;
                    Session["hoten"] = hoten;
                    Session["pass"] = pass;
                    Response.Redirect("DangNhap.aspx");
                }
            }

            /*if (IsPostBack)
            {
                string tenDangKi = Request.Form["tenDangKi"];
                string mkDangKi = Request.Form["mkDangKi"];
                List<classUser> list = new List<classUser>();
                list = (List<classUser>)Session["user"];
                list.Add(new classUser(tenDangKi, mkDangKi));
                Session["user"] = list;
                Response.Redirect("DangNhap.aspx");
                
            }*/
            /*if (IsPostBack)
            {
                string user = Request.Form["userName"];
                string pass = Request.Form["password"];
                List<ClassUser> list = new List<ClassUser>();
                list = (List<ClassUser>)Application["user"];
                list.Add(new ClassUser(user, pass));
                Application["user"] = list;
                Response.Redirect("DangNhap.aspx");
            }*/
        }
    }
}