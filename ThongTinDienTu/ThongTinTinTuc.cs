using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThongTinDienTu
{
    public class ThongTinTinTuc
    {
        private string id;
        private string idtype;
        private string tieude;
        private string gt;
        private string noidung;
        private string imagefile; 

        public ThongTinTinTuc(string id, string idtype, string tieude, string gt, string noidung, string imagefile)
        {
            this.id = id;
            this.idtype = idtype;
            this.tieude = tieude;
            this.noidung = noidung;
            this.gt = gt;
            this.imagefile = imagefile;
        }

        public string Id { get => id; set => id = value; }
        public string Idtype { get => idtype; set => idtype = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string GT { get => gt; set => gt = value; }
        public string ImageFile { get => imagefile; set => imagefile = value; }
    }
}