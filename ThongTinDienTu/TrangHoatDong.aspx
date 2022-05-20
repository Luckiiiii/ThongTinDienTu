<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangHoatDong.aspx.cs" Inherits="ThongTinDienTu.TrangHoatDong" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang Hoạt Động</title>
    <link href="StyleSheet.css?v=123" rel="stylesheet" type="text/css" />
    <style>
        .content {
            
            border: 1px solid #bebebe;
            border-radius: 4px;
            width:99.8%;
            
            
        }

        .tom_tat {
            display: flex;
            padding:1%;
        }

        .duongDan {
            padding-top:0.4%;
            padding-right:2em;
            background: none repeat scroll 0 0 #f9f9f9;
            border-bottom: 1px solid #bebebe !important;
            border-top: none !important;
            border-right: none !important;
            border-left: none !important;
            height: 30px;
            margin-bottom: 12px;
            margin-top: 0 !important;
            border-radius: 4px 4px 0 0;
        }

        .dg {
            font-size: 20px !important;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            margin-left:2%;
        }

        .tin_abstract {
            color: black;
            font-family: Arial,Helvetica,sans-serif;
            font-size: 12px;
            line-height: 18px;
            margin: 0 0px;
            text-align: justify;
            text-decoration: none;
            vertical-align: middle;
            width: auto;
        }

        .tin_title {
            font-family: Arial,Helvetica,sans-serif;
            font-size: 12px;
            font-weight: bold;
            line-height: 16px;
            margin: 0 0px;
            text-align: justify;
            text-decoration: none;
            vertical-align: middle;
            width: auto;
        }
        .tom_tat > div > p >a{
            text-decoration: none;
        } 
        @media only screen and (max-width: 768px) {
            .tom_tat{
                flex-direction:column;
            }
        }
    </style>
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
            <div class="duongDan">
                <a class="dg">Tin Tức - Hoạt Động</a>
            </div>
            <%= showHD() %>
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
