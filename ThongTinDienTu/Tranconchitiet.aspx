<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tranconchitiet.aspx.cs" Inherits="ThongTinDienTu.Tranconchitiet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang con chi tiet</title>
    <style>
        .content{
            padding:10px;
        }
        .article{
            
        }
        .articleTitle{
            font-size: 20pt;
	        font-weight: bold;
	        line-height: 36pt;
	        text-align: center;
        }
        .articleTime,.taglist{
            float:right;
            display:block;
        }
        .taglist {
            text-align: right;
            /* font-style: italic; */
            margin-left: 0;
            margin-bottom: 2px;
            margin-top: 2px;
        }
        .articleContent{
	        clear: both;
}
    </style>
    <link href="StyleSheet.css?v=123" rel="stylesheet" type="text/css" />
</head>
<body>
    <header>
        <img src="images/Hou.jpg" class ="" alt="Hou"/>
        <nav>
            <ul class="main-menu">
                <li class="main-menu-item"><a href="TrangChu.aspx">Trang Chủ</a></li>
                <li class="main-menu-item"><a href="#">Tin tức</a>
                    <ul class="menu2">
                        
                        <li class="menu2-item"><a class="menu2-item-link" href="TrangDaoTao.aspx">Đào tạo</a></li>
                        <li class="menu2-item"><a class="menu2-item-link" href="TrangTuyenSinh.aspx">Tuyển sinh</a></li>
                        <li class="menu2-item"><a class="menu2-item-link" href="TrangHoatDong.aspx">Hoạt động</a></li>
                        <li class="menu2-item"><a class="menu2-item-link" href="TrangKeHoach.aspx">Kế hoạch</a></li>
                    </ul>
                </li>
                 <li class="main-menu-item"><a href="GioiThieu.aspx">Giới thiệu</a></li>
                <%--<li class="main-menu-item"><a href="DangKi.aspx">Đăng kí</a></li>--%>
                <li class="main-menu-item"><a href="DangKi.aspx">Đăng kí</a>|<a href="DangNhap.aspx">Đăng nhập</a>|<a href="DangXuat.aspx">Đăng Xuất</a><a id="name" runat="server"></a></li>
            </ul>
        </nav>
    </header>
    <main>
        <div class="content">
            <div class="article">
                <h1 class="articleTitle" id="title" runat="server"></h1>
               
                <div class="clear"></div>
                <div class="articleAbstract"> Khoa tin học thuộc Viện Đại Học Nở Hà Nội (FITHOU) được Bộ Giáo Dục và Đào Tạo quyết định thành lập theo quyết định số 2653/QĐ-TCCB ngày 01/12/1993.</div>
                
                <div class="articleContent">
                    <p style="text-align:justify;" id="noiDung" runat="server"></p>

                </div>
                
            </div>
            <%--<div id="anh" runat="server">
                    
                </div>--%>
        </div>
    </main>
    <footer>
        
        <div class="footerd">
            <div style="float: left;">
                <p>Khoa công nghệ thông tin - Trường Đại Học Mở Hà Nội</p>
                <br />
                <p>Địa chỉ: B101 Nguyễn Hiền - Hai Bà Trưng - Hà Nội</p>
                <br />
                <p>Khu giảng đường: 96 Định Công</p>
            </div>
            <div style="float: right;">
                <div style="text-align: right">
                    <p>Phát triển và cung cấp bởi</p>
                    <br />
                    <p>Trung tâm công nghệ và dịch vụ trực tuyến (FITHOU OTSC)</p>
                </div>
            </div>
        </div>
    </footer>
</body>
</html>
