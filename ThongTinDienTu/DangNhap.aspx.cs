using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThongTinDienTu
{
    public partial class DangNhap : System.Web.UI.Page
    {
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Session["timekt"] != null)
            {
                DateTime loginTime = (DateTime)Session["timekt"];
                var loginTimeDurationInMinutes = (DateTime.Now - loginTime).Minutes;


                if (loginTimeDurationInMinutes <= 2)
                {
                    dn.Disabled = true;
                }
                else
                {
                    dn.Disabled = false;
                }
            }*/
            int count = 0;
            int check = 0;
            if (IsPostBack)
            {
                string email = Request.Form["email"];
                string hoten = Request.Form["hoten"];
                string pass = Request.Form["pass"];
                List<classUser> list = (List<classUser>)Application["user"];
                /*if (Application["dem"] == null)
                {
                    Application["dem"] = 1;
                }
                else
                {
                    Application["dem"] = (int)Application["dem"] + 1;
                }
                if ((int)Application["dem"] > 3)
                {
                    Session["timebd"] = DateTime.Now;
                    Application["dem"] = null;
                    Response.Redirect("Error.aspx");
                }
                else
                {
                    loi_dn.InnerHtml = "Nhập sai lần" + Application["dem"];
                }*/
                
                    //Response.Write("<script>alert("+"Bạn nhập sai lần thứ" + (int)Application["dem"] + ")</script>");
                    //Response.Write("Sai lan:" + Application["dem"]);
                

                foreach (classUser us in list)
                {
                    count++;

                    if (us.Email == email && us.Pass == pass)
                    {
                        Session["login_time"] = DateTime.Now;
                        //Application["dem"] = null;
                        Session["email"] = us.Email;
                        Session["hoten"] = us.HoTen;
                        Session["pass"] = us.Pass;
                        Response.Redirect("TrangChu.aspx");
                        /*Application["dem"] = null;
                        Session["login_time"] = DateTime.Now;
                        Application["name"] = ten.UserName;
                        Response.Redirect("Trangchu.aspx");*/
                        check = 1;
                    }
                    


                    //Response.Write("<script>alert("+count+")</script>");


                }
                if (check == 0)
                {
                    loi_dn.InnerText = "Tai khoan khong ton tai";
                }
                Response.Write("So tai khoan da dang ky" + count);
                dem.InnerText = "so luong" + count.ToString();

            }

            /*name.InnerHtml =
                   "Xin chào, " + Session["name"].ToString()*/
        }
        //public DateTime t = new DateTime(3000, 12, 31, 5, 10, 20);
        /*public void checkMK()
        {
            //DateTime t = new DateTime(3000, 12, 31, 5, 10, 20);
            string tenDangNhap = Request.Form["TenDangNhap"];
            string mkDangNhap = Request.Form["mkDangNhap"];
            List<classUser> list = (List<classUser>)Session["user"];
            *//*if (DateTime.Now >= t)
            {
                dn.Disabled = false;
                dem.Value = "1";

            }*//*
            if (dem.Value == "11")
            {
                dn.Disabled = true;
                //t = DateTime.Parse(tg.Value);
                //tg.value = DateTime.Now.AddSeconds(10).ToString();
                //DateTime a 
                Application["count"] = DateTime.Now;
                Response.Redirect("Error.aspx");
                


            }
            else
            {
                foreach (classUser ten in list)
                {
                    if (IsPostBack)
                    {
                        if (tenDangNhap == ten.UserName && mkDangNhap == ten.PassWord)
                        {
                            Session["login_time"] = DateTime.Now;
                            Application["name"] = ten.UserName;
                            Response.Redirect("Trangchu.aspx");
                        }
                        else
                        {
                            //Application["Count"] = 0;
                            dem.Value = dem.Value + "1";
                            //t = DateTime.Now.AddSeconds(5);
                            tg.Value = DateTime.Now.AddSeconds(5).ToString();
                        }
                    }
                    //Response.Write("<script>alert(" + dem.Value + ")</script>");
                }
            }
        }*/
    }
}
/*if (Session["dem"] == null)
{
    Session["dem"] = 1;
}
else
{
    Session["dem"] = (int)Session["dem"] + 1;
}
if ((int)Session["dem"] > 3)
{
    Session["dem"] = null;
    Response.Redirect("thongbaoloi.html");
}
else
{
    Response.Write("Bạn nhập sai lần thứ" + Session["dem"]);
}*/