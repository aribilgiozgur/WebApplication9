<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="WebApplication9.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Eşya Girişi</h1>

        <p>Eşya Adı</p>
        <asp:TextBox runat="server" ID="txtEsyaAdi"/><br />
        <p>Eşya Sayısı</p>
        <asp:TextBox runat="server" ID="txtEsyaSayisi" /><br />
        <asp:Button Text="Gönder" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click"/>
    </div>
    </form>
</body>
</html>
