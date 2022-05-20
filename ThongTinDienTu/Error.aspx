<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="ThongTinDienTu.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>THÔNG BÁO</h1>
    <h3>Tài khoản của bạn sai quá 3 lần, vui lòng đợt 5s để đăng nhập lại.</h3>
    <h2 id="demo"></h2>

    <script>
        const myTimeout = setTimeout(myGreeting, 5000);

        function myGreeting() {
            document.getElementById("demo").innerHTML = "<a href='DangNhap.aspx'>Đăng nhập</a>"
        }
    </script>
</body>
</html>
