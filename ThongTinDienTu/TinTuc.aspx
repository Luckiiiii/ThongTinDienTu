<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinTuc.aspx.cs" Inherits="ThongTinDienTu.TinTuc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tin Tức</title>
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
                <li class="main-menu-item"><a href="TinTuc.aspx">Tin tức</a>
                    <ul class="menu2">
                        <li class="menu2-item"><a class="menu2-item-link" href="TrangDaoTao.aspx">Đào tạo</a></li>
                         <li class="menu2-item"><a class="menu2-item-link" href="DaoTao.aspx">Tuyển sinh</a></li>
                         <li class="menu2-item"><a class="menu2-item-link" href="DaoTao.aspx">Hoạt động</a></li>
                         <li class="menu2-item"><a class="menu2-item-link" href="DaoTao.aspx">Kế hoạch</a></li>
                    </ul>
                </li>
                <li class="main-menu-item"><a href="GioiThieu.aspx">Giới thiệu</a></li>
                <li class="main-menu-item"><a href="DangKi.aspx">Đăng kí</a></li>
                <li class="main-menu-item"><a href="DangNhap.aspx">Đăng nhập</a></li>
                <%--<li id="name" runat="server"></li>--%>
            </ul>
        </nav>
    </header>
    <main>
        <div class="content">
            <div class="duongDan">
                <a class="dg">Tin Tức</a>
            </div>
            <div class="tom_tat">
                <div>
                    <div class ="img_anh">
                        <img src="images/FITHOU.jpg" alt="Alternate Text"/>
                    </div>
                </div>
                <div>
                    <div class="tin_tilte">
                        <a href="#">Trường Đại học Mở Hà Nội công bố Đề án tuyển sinh năm 2022</a>
                    </div>
                    <div class="tintic_abstract">
                        " Theo Đề án tuyển sinh năm 2022, Trường Đại học Mở Hà Nội tuyển sinh đại học các hệ Chính quy, Vừa làm vừa học, Từ xa, Văn bằng hai chính quy, Liên thông đại học chính quy, song bằng, Liên kết quốc tế. Cùng với đó, Trường tuyển sinh 7 ngành của trình độ thạc sĩ và ngành Ngôn ngữ Anh ở trình độ Tiến sĩ.
                        Đối với đại học hệ chính quy, Trường Đại học Mở Hà Nội tuyển sinh 18 ngành với 3.600 chỉ tiêu. Trường dành 3.270 chỉ tiêu xét tuyển sử dụng kết quả thi tốt nghiệp THPT, 250 chỉ tiêu xét tuyển học bạ và 80 chỉ tiêu xét kết quả bài thi đánh giá năng lực do ĐH Quốc gia Hà Nội tổ chức."
                    </div>
                    <p style="float: right;">
                        <a href="#" style="font-style:italic;">Xem chi tiết</a>
                    </p>
                </div>
            </div>
            <div class="tom_tat">
                <div>
                    <div class ="img_anh">
                        <img src="images/FITHOU.jpg" alt="Alternate Text"/>
                    </div>
                </div>
                <div>
                    <div class="tin_tilte">
                        <a href="#">Trường Đại học Mở Hà Nội công bố Đề án tuyển sinh năm 2022</a>
                    </div>
                    <div class="tintic_abstract">
                        " Theo Đề án tuyển sinh năm 2022, Trường Đại học Mở Hà Nội tuyển sinh đại học các hệ Chính quy, Vừa làm vừa học, Từ xa, Văn bằng hai chính quy, Liên thông đại học chính quy, song bằng, Liên kết quốc tế. Cùng với đó, Trường tuyển sinh 7 ngành của trình độ thạc sĩ và ngành Ngôn ngữ Anh ở trình độ Tiến sĩ.
                        Đối với đại học hệ chính quy, Trường Đại học Mở Hà Nội tuyển sinh 18 ngành với 3.600 chỉ tiêu. Trường dành 3.270 chỉ tiêu xét tuyển sử dụng kết quả thi tốt nghiệp THPT, 250 chỉ tiêu xét tuyển học bạ và 80 chỉ tiêu xét kết quả bài thi đánh giá năng lực do ĐH Quốc gia Hà Nội tổ chức."
                    </div>
                    <p style="float: right;">
                        <a href="#" style="font-style:italic;" >Xem chi tiết</a>
                    </p>
                </div>
            </div>
            <div class="tom_tat">
                <div>
                    <div class ="img_anh">
                        <img src="images/FITHOU.jpg" alt="Alternate Text"/>
                    </div>
                </div>
                <div>
                    <div class="tin_tilte">
                        <a href="#">Trường Đại học Mở Hà Nội công bố Đề án tuyển sinh năm 2022</a>
                    </div>
                    <div class="tintic_abstract">
                        " Theo Đề án tuyển sinh năm 2022, Trường Đại học Mở Hà Nội tuyển sinh đại học các hệ Chính quy, Vừa làm vừa học, Từ xa, Văn bằng hai chính quy, Liên thông đại học chính quy, song bằng, Liên kết quốc tế. Cùng với đó, Trường tuyển sinh 7 ngành của trình độ thạc sĩ và ngành Ngôn ngữ Anh ở trình độ Tiến sĩ.
                        Đối với đại học hệ chính quy, Trường Đại học Mở Hà Nội tuyển sinh 18 ngành với 3.600 chỉ tiêu. Trường dành 3.270 chỉ tiêu xét tuyển sử dụng kết quả thi tốt nghiệp THPT, 250 chỉ tiêu xét tuyển học bạ và 80 chỉ tiêu xét kết quả bài thi đánh giá năng lực do ĐH Quốc gia Hà Nội tổ chức."
                    </div>
                    <p style="float: right;">
                        <a href="#" style="font-style:italic;">Xem chi tiết</a>
                    </p>
                </div>
            </div>
            <div class="tom_tat">
                <div>
                    <div class ="img_anh">
                        <img src="images/FITHOU.jpg" alt="Alternate Text"/>
                    </div>
                </div>
                <div>
                    <div class="tin_tilte">
                        <a href="#">Trường Đại học Mở Hà Nội công bố Đề án tuyển sinh năm 2022</a>
                    </div>
                    <div class="tintic_abstract">
                        " Theo Đề án tuyển sinh năm 2022, Trường Đại học Mở Hà Nội tuyển sinh đại học các hệ Chính quy, Vừa làm vừa học, Từ xa, Văn bằng hai chính quy, Liên thông đại học chính quy, song bằng, Liên kết quốc tế. Cùng với đó, Trường tuyển sinh 7 ngành của trình độ thạc sĩ và ngành Ngôn ngữ Anh ở trình độ Tiến sĩ.
                        Đối với đại học hệ chính quy, Trường Đại học Mở Hà Nội tuyển sinh 18 ngành với 3.600 chỉ tiêu. Trường dành 3.270 chỉ tiêu xét tuyển sử dụng kết quả thi tốt nghiệp THPT, 250 chỉ tiêu xét tuyển học bạ và 80 chỉ tiêu xét kết quả bài thi đánh giá năng lực do ĐH Quốc gia Hà Nội tổ chức."
                    </div>
                    <p style="float: right;">
                        <a href="#" style="font-style:italic;">Xem chi tiết</a>
                    </p>
                </div>
            </div>
            <div class="tom_tat">
                <div>
                    <div class ="img_anh">
                        <img src="images/FITHOU.jpg" alt="Alternate Text"/>
                    </div>
                </div>
                <div>
                    <div class="tin_tilte">
                        <a href="#">Trường Đại học Mở Hà Nội công bố Đề án tuyển sinh năm 2022</a>
                    </div>
                    <div class="tintic_abstract">
                        " Theo Đề án tuyển sinh năm 2022, Trường Đại học Mở Hà Nội tuyển sinh đại học các hệ Chính quy, Vừa làm vừa học, Từ xa, Văn bằng hai chính quy, Liên thông đại học chính quy, song bằng, Liên kết quốc tế. Cùng với đó, Trường tuyển sinh 7 ngành của trình độ thạc sĩ và ngành Ngôn ngữ Anh ở trình độ Tiến sĩ.
                        Đối với đại học hệ chính quy, Trường Đại học Mở Hà Nội tuyển sinh 18 ngành với 3.600 chỉ tiêu. Trường dành 3.270 chỉ tiêu xét tuyển sử dụng kết quả thi tốt nghiệp THPT, 250 chỉ tiêu xét tuyển học bạ và 80 chỉ tiêu xét kết quả bài thi đánh giá năng lực do ĐH Quốc gia Hà Nội tổ chức."
                    </div>
                    <p style="float: right;">
                        <a href="#" style="font-style:italic;">Xem chi tiết</a>
                    </p>
                </div>
            </div>
        </div>
    </main>
    <footer>
        <nav>
            <ul class="main-menu">
                <li><a href="TrangChu.aspx">Trang Chủ</a></li>
                <li><a href="TinTuc.aspx">Tin tức</a></li>
                <li><a href="GioiThieu.aspx">Giới thiệu</a></li>
                <li><a href="DangKi.aspx">Đăng kí</a></li>
                <li><a href="DangNhap.aspx">Đăng nhập</a></li>
            </ul>
        </nav>
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
