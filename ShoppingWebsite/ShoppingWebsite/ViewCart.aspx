<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="ShoppingWebsite.ViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <%--<table style="width:100%;">
            <tr>
                <td> <asp:Label ID="txttitle" runat="server" Text="Label"></asp:Label></td>
                <td> <asp:Label ID="txtName" runat="server" Text="Label"></asp:Label></td>
                <td> <asp:Label ID="txtGenreName" runat="server" Text="Label"></asp:Label></td>
                <td> <asp:Label ID="txtDescription" runat="server" Text="Label"></asp:Label></td>
                <td> <asp:Label ID="txtPrice" runat="server" Text="Label"></asp:Label></td>
            </tr>
        </table>--%>

        <%--<asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li><%#Eval("Title") %> </li>
                <li><%#Eval("Name") %></li>
                <li><%#Eval("Name") %></li>
                <li><%#Eval("Description") %></li>
                <li><%#Eval("Price") %></li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>--%>

        <table>

        </table>

        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Checkout" />
    </form>
</body>
</html>
