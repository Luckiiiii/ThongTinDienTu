<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GioiThieu.aspx.cs" Inherits="ThongTinDienTu.GioiThieu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css?v=123" rel="stylesheet" type="text/css" />
    <title>Giới thiệu</title>
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
</head>
<body>
    <header>
        <img src="images/Hou.jpg" class="" alt="Hou"/>
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
                <h1 class="articleTitle">Giới thiệu chung về khoa Công Nghệ Thông Tin - Viện ĐH Mở HN</h1>
                <span id="ThoiGianDang" class="articleTime">27/10/2015 12:23</span>
                <div class="clear"></div>
                <div class="articleAbstract"> Khoa tin học thuộc Viện Đại Học Nở Hà Nội (FITHOU) được Bộ Giáo Dục và Đào Tạo quyết định thành lập theo quyết định số 2653/QĐ-TCCB ngày 01/12/1993.</div>
                <div class="taglist">
                    <div class="clear"></div>
                    " Tag: "
                    <a href="#"></a>
                </div>
                <div class="articleContent">
                    <p style="text-align:justify;"> Hàng năm, Khoa lấy ngày 15 tháng 3 làm ngày truyền thống trên cơ sở là ngày đầu tiên được tổ chức đào
                        tạo ngành tin học tại Viện Đại học Mở Hà Nội.Từ năm 2011, Khoa chính thức được mang tên là Khoa Công nghệ Thông tin theo quyết định
                        số 71/QĐ-ĐHM-TC ngày 29/03/2011 của Viện trưởng Viện Đại học Mở Hà Nội. Khoa Công nghệ Thông tin (CNTT) có trách nhiệm tổ chức đào 
                        tạo các ngành Công nghệ Thông tin (mã ngành 52480201, trình độ Đại học). Tin học ứng dụng (trình độ Cao đẳng). Các hệ đào tạo và loại
                        hình đào tạo gồm: Chính quy; Vừa học vừa làm; Từ xa; Văn bằng hai; Từ xa theo phương thức E-Learning; Liên thông từ Cao đẳng lên Đại học;
                        Liên thông từ Trung cấp lên Đại học. Bên cạnh đó, Khoa luôn thực hiện tốt nhiệm vụ tổ chức nghiên cứu khoa học, phát triển ứng dụng về CNTT
                        và chuyển giao công nghệ, phối hợp với Khoa Sau đại học hỗ trợ về chuyên môn trong công tác đào tạo sau đại học chuyên ngành CNTT.</p>

                </div>
            </div>
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
