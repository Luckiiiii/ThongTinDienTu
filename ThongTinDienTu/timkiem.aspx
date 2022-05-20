<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="timkiem.aspx.cs" Inherits="ThongTinDienTu.timkiem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang tìm kiếm</title>
</head>
<body>
    <header>
        <form runat="server" method="get" action="timkiem.aspx">
            <div style="height: 100px;">
                <div class="search-box">
                    <input name="search" type="text" placeholder="Tìm Kiếm..." />
                </div>
            </div>
        </form>
    </header>
    <div >
        <h3>NỘI DUNG TÌM KIẾM</h3>
    </div>
    <div id="contentSearch" runat="server">
    </div>

</body>
</html>
