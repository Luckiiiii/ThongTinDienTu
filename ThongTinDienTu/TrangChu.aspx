<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="ThongTinDienTu.TrangChu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang Chủ</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style>
        .blockMain {
            margin-left: 0.4%;
            border: 1px solid #bebebe;
            border-radius: 4px;
            margin-bottom: 5px;
            margin-top: 0;
            overflow: hidden;
            width: 99%;
        }

        .blockMainBody {
            display: flex;
             
        }
        .blockMainBody-left{
            width:80%;
        }

        .blockMain h2 {
            margin-top: 0.4%;
            border-bottom: 1px solid #bebebe !important;
            color: #095d90 !important;
            font-family: arial;
            line-height: 20px;
            margin: 0;
            padding-left: 5px;
            padding-right: 5px;
            text-align: left;
            text-transform: uppercase !important;
            vertical-align: middle;
            font-weight: bold;
        }

        h2 a {
            color: #095d90 !important;
            font-size: 12px;
            line-height: 24px;
            font-weight: bold;
        }

        h3 {
            font-size: 16px;
            font-weight: bold;
            line-height: 18px;
            margin: 12px 0;
        }

        .ulnewr li {
           
            border-bottom: 1px solid #ededed;
            border-right: 0px solid #ededed;
            font-weight: bold;
            margin-bottom: 0 !important;
            padding: 7px 10px 7px 12px !important;
        }
        
        .column {
            margin-left: 0.4%;
            display: flex;
            
        }

        .row {
            flex: 1;
        }

        .layout {
            border: 1px solid #bebebe;
            border-radius: 4px;
            margin-bottom: 5px;
            margin-top: 0;
            overflow: hidden;
            width: 98.7%;
        }

        div.left_block h2 {
            border-bottom: 1px solid #bebebe !important;
            color: #095d90 !important;
            font-family: arial;
            line-height: 20px;
            margin: 0;
            padding-left: 5px;
            text-align: left;
            text-transform: uppercase !important;
            vertical-align: middle;
            font-weight: bold;
        }
        .ulnewr >li> a{
            text-decoration: none;
        }

        @media only screen and (max-width: 1350px) {
            .blockMainBody {
                flex-direction: column;
            }

            .column {
                flex-direction: column;
            }
            .blockMainBody-left{
                width:90%;
                padding-left:53px;
            }
            .blockMainBody-left > a > img{
                width:99%;
            }
            .layout{
                width:99.4%;
            }
            
        }
        .main-menu{
            
        }

    </style>
</head>
<body>
    <header>
        <img src="images/Hou.jpg" class="" alt="Hou"/>
        <nav>
            <ul class="main-menu">
                
                <li class="main-menu-item"><a href="">Tin tức</a>
                    <ul class="menu2">

                        <li class="menu2-item"><a class="menu2-item-link" href="TrangDaoTao.aspx">Đào tạo</a></li>
                        <li class="menu2-item"><a class="menu2-item-link" href="TrangTuyenSinh.aspx">Tuyển sinh</a></li>
                        <li class="menu2-item"><a class="menu2-item-link" href="TrangHoatDong.aspx">Hoạt động</a></li>
                        <li class="menu2-item"><a class="menu2-item-link" href="TrangKeHoach.aspx">Kế hoạch</a></li>
                        <li class="menu2-item"><a class="menu2-item-link" href="GioiThieu.aspx">Giới thiệu</a></li>
                        <li class="menu2-item"><a class="menu2-item-link" href="TrangChu.aspx">Trang Chủ</a></li>
                        <%--<li class="main-menu-item"><a href="DangKi.aspx">Đăng kí</a></li>--%>
                        <li class="menu2-item"><a class="menu2-item-link"  href="DangKi.aspx">Đăng kí</a></li>
                        <li class="menu2-item"><a class="menu2-item-link"  href="DangNhap.aspx">Đăng nhập</a></li>
                        <li class="menu2-item"><a class="menu2-item-link"  href="DangXuat.aspx">Đăng Xuất</a></li>
                    </ul>
                </li>
                
                
            </ul>
        </nav>
    </header>
    <main>
        <div class="blockMain">
            <h2>
                <a>TIN TỨC - SỰ KIỆN NỔI BẬT</a>
                <%--<form runat="server" method="get" action="timkiem.aspx">
                    <div>
                        <div>
                            <input name="search" type="text" placeholder="Tìm Kiếm..." />
                        </div>
                    </div>
                </form>--%>
            </h2>
            <div class="blockMainBody">
                <div class="blockMainBody-left">
                    <a href="Tranconchitiet.aspx?id=1.5" title="Hou">
                        <img src="images/IMG_0093.jpg" alt="Alternate Text" title="Hou" />
                    </a>
                    <h3>
                        <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Trường Đại học Mở Hà Nội công bố Đề án tuyển sinh năm 2022</a>
                    </h3>
                    <p>
                        Theo Đề án tuyển sinh năm 2022, Trường Đại học Mở Hà Nội tuyển sinh đại họccc các Chính quy, Vừa làm vừa học, Từ xaa, Văn bằng hai chính quy, Liên thônggg đại học chính quy, song bằng, Liên kết quốc tế. Cùng với đó, Trường tuyển sinh 7 ngành của trình độ thạc sĩ và ngành Ngôn ngữ Anh ở trình độ Tiến sĩ.
                        Đối với đại họcccc hệ chính quy, Trường Đại học Mở Hà Nội tuyển sinh 18 ngành với 3.600 chỉ tiêu. Trường dành 3.270 chỉi tiêu xét tuyển sử dụng kết quả thi tốt nghiệp THPT, 250 chỉ tiêuuu xét tuyển học bạ và 80 chỉ tiêu xét kết quả bài thii đánh giá năng lực do ĐH Quốc gia Hà Nội tổ chức.
                    </p>
                </div>

                <div class="blockMainBody-right">
                    <ul class="ulnewr">
                        <li>
                            <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Bộ môn Công nghệ đa phương tiện thông báo lịch tổ chức Đánh giá chuyên môn đồ án tốt nghiệp HK2 (năm học 2021-2022)
                            </a>
                        </li>
                        <li>
                            <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Thông báo Hội đồng báo cáo chuyên môn đồ án HK2 năm học 2021 - 2022 Bộ môn Công nghệ phần mềm</a>
                        </li>
                        <li>
                            <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Thông báo Hội đồng báo cáo chuyên môn đồ án KH2 năm học 2021 - 2022 Bộ môn Mạng, Kỹ thuật máy tính và bảo mật doanh nghiệp</a>
                        </li>
                        <li>
                            <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Lịch hoạt động đầu khoá đối với sinh viên khoá 1810A (ngành CNTT, nhập học năm 2018)</a>
                        </li>
                        <li>
                            <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Thông báo Danh sách thi, Lịch thi Đợt 2 các môn Tiếng Anh cơ bản - học kỳ 1 năm học 2021-2022 (theo hình thức trực tuyến)</a>
                        </li>
                        <li>
                            <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Tuyển sinh đào tạo đại học liên thông - hệ chính quy ngành Công nghệ thông tin</a>
                        </li>
                        <li>
                            <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Thông báo Hội đồng báo cáo chuyên môn đồ án KH2 năm học 2021 - 2022 Bộ môn Mạng, Kỹ thuật máy tính và bảo mật doanh nghiệp</a>
                        </li>
                        <li>
                            <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Bộ môn Công nghệ đa phương tiện thông báo lịch tổ chức Đánh giá chuyên môn đồ án tốt nghiệp HK2 (năm học 2021-2022)
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="column">
            <div class="row">
                <div class="layout">
                    <div class="left_block">
                        <h2 class="header-logo">
                            <a>Tin Đào Tạo</a>
                        </h2>
                        <div>
                            <div class="container-daotao">
                                <h3>
                                    <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Thông báo QĐ số 696/QĐ-ĐHM và Danh sách SV được công nhận tốt nghiệp đợt tháng 2 năm 2022</a>
                                </h3>
                                <p>
                                    Thông báo QĐ số 696/QĐ-ĐHM và Danh sách SV được công nhận tốt nghiệp đợt tháng 2 năm 2022
                                </p>
                                <hr />
                                <div>
                                    <h6>
                                        <a href="TrangDaoTao.aspx">Xem tiếp</a>
                                    </h6>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="layout">
                    <div class="left_block">
                        <h2 class="header-logo">
                            <a>Tin hoạt động</a>
                        </h2>
                        <div>
                            <div class="container-hoatdong">
                                <h3>
                                    <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Thông báo tập huấn kỹ năng mềm NCKH cho sinh viên tham gia NCKH SV năm 2021-2022</a>
                                </h3>
                                <p>
                                    Thực hiện kế hoạch công tác NCKH năm học 2021 – 2022 và nhằm nâng cao hiệu quả của báo cáo kết quả NCKH SV
                                </p>
                                <hr />
                                <div>
                                    <h6>
                                        <a href="TrangHoatDong.aspx">Xem tiếp</a>
                                    </h6>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="column">
            <div class="row">
                <div class="layout">
                    <div class="left_block">
                        <h2 class="header-logo">
                            <a>Kế hoạch</a>
                        </h2>
                        <div>
                            <div class="container-daotao">
                                <h3>
                                    <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Thông báo Kế hoạch Đào tạo và một số hoạt động HK2 năm học 2021-2022</a>
                                </h3>
                                <p>
                                    cập nhật ngày 09/02/2022, kế hoạch đào tạo và quy trình cho học kì 2 + kì 3 năm học 2022
                                </p>
                                <hr />
                                <div>
                                    <h6>
                                        <a href="TrangKeHoach.aspx">Xem tiếp</a>
                                    </h6>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="layout">
                    <div class="left_block">
                        <h2 class="header-logo">
                            <a>Tin tuyển sinh</a>
                        </h2>
                        <div>
                            <div class="container-daotao">
                                <h3>
                                    <a href="Tranconchitiet.aspx?id=1.5" title="Hou">Trường Đại học Mở Hà Nội công bố Đề án tuyển sinh năm 2022</a>
                                </h3>
                                <p>
                                    Theo Đề án tuyển sinh năm 2022, Trường Đại học Mở Hà Nội tuyển sinh đại học các hệ Chính quy, Vừa làm vừa học,
                                    Từ xa
                                   
                                </p>
                                <hr />
                                <div>
                                    <h6>
                                        <a href="TrangTuyenSinh.aspx">Xem tiếp</a>
                                    </h6>
                                </div>
                            </div>
                        </div>
                    </div>
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
