<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication9.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Deneme!</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <a href="Add.aspx">Yeni Eşya gir</a>
    <table>
        <tr>
            <td>Eşyalar</td>
        </tr>        
        <asp:Repeater runat="server" ID="rptItems">
            <ItemTemplate>
                <tr>
                    <td>
                        <a href="view.aspx?Id=<%# Eval("Id") %>"><%# Eval("ItemName") %></a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </div>
    </form>
</body>
</html>
