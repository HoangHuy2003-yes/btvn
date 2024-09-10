<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính thể tích hình nón cụt </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Tính thể tích hình nón cụt</h2>

            <label for="lon">Nhập bán kính đáy lớn : </label>
            <asp:TextBox ID="lon" runat="server"></asp:TextBox>
            <br /><br />

            <label for="nho">Nhập bán kính đáy nhỏ : </label>
            <asp:TextBox ID="nho" runat="server"></asp:TextBox>
            <br /><br />

            <label for="cao">Nhập chiều cao : </label>
            <asp:TextBox ID="cao" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnCalculate" runat="server" Text="Chạy" OnClick="btnCalculate_Click" />
            <br /><br />

            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

