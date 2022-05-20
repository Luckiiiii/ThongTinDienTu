using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThongTinDienTu
{
    public class classUser
    {
        string email;
        string hoten;
        string pass;

        

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public classUser(string email, string hoten, string pass)
        {
            this.email = email;
            this.hoten = hoten;
            this.pass = pass;
        }
    }
}