<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="ThongTinDienTu.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng Nhập</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <script src="js/dangnhap.js"></script>
    <style>
        * {
            margin: 0;
            padding: 0;
        }

        body {
            font-family: Arial, sans-serif;
            
            background-size: cover;
            min-height: 100vh;
            background-repeat: no-repeat;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .form_login {
            max-width: 500px;
        }

        .content_main {
            background-color: #ffffff;
            padding: 30px;
            border-radius: 5px;
        }

        .title {
            margin-bottom: 18px;
            text-align: center;
        }

        .content {
        }

        .content_input input {
            box-sizing: border-box;
            width: 100%;
            margin-top: 10px;
            padding: 9px 10px 9px 10px;
            display: block;
        }

        .content_input span {
            display: none;
            color: #ff0000;
        }

        .moved_on {
            float: right;
            margin-top: 10px;
        }

            .moved_on a {
                text-decoration: none;
                color: #0288d1;
            }

        .inpsubmit {
            background-color: #0288d1;
            cursor: pointer;
            width: 100%;
            border: 1px solid #0288d1;
            text-align: center;
            margin-top: 50px;
            display: block;
            color: white;
            text-transform: uppercase;
            padding: 7px 0;
            border-radius: 3px;
        }

        .notice_policy {
            text-align: center;
            color: #707070;
            padding-top: 10px;
            padding-bottom: 10px;
        }
    </style>
</head>
<body>
    
    <form class="form_login" runat="server" method="post" onsubmit="return checkdangnhap()">
        <div class="content_main">
            <h2 class="title">Đăng nhập</h2>
            <div class="content">
                <div class="content_input">
                    <input id="email" name="email" placeholder="Email" value="" runat="server" />
                    <span id="loi_email"></span>
                    <input type="password" id="pass" name="pass" placeholder="Mật khẩu" value="" runat="server" />
                    <span id="loi_pass"></span>
                </div>
                <div class="moved_on">
                    <span class="right">Chưa có tài khoản? <a href="dangki.aspx">Đăng ký ngay</a></span>
                </div>
                <span id="loi_dn" runat="server"></span>
                <input type="submit" name="dangnhap" id="dn" runat="server" class="inpsubmit" value="Đăng nhập" />
                <p id="dem" runat="server"></p>
            </div>
            <br />
            <div class="notice_policy">Chúng tôi không sử dụng thông tin của bạn với bất kỳ mục đích nào.
        </div>
    </form>
    <script src="js/dangnhap.js"></script>
</body>
</html>
