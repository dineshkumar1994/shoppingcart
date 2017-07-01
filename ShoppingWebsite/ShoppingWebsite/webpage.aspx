<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webpage.aspx.cs" Inherits="ShoppingWebsite.webpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <table border="0" width="600px" cellpadding="2" cellspacing="1" style="border: 1px solid maroon;">
                <tr bgcolor="blue">
                    <th>Album Name</th>
                    <th>Artist Name</th>
                    <th>Genre Name</th>
                </tr>
            List of Songs Available For Purchase

        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td width="200">
                    <li>
                        <a href="songspage.aspx?title=<%#Eval("Title") %>" title="<%#Eval("Title") %>">
                            <%#Eval("Title") %>
                        </a>
                    </li>


                </td>
                <td>
                  <li>  <%#Eval("Artist Name") %> </li>

                </td>
                <td width="150">
                    <li><%#Eval("Genre Name") %> </li>
                </td>

            </tr>
        </ItemTemplate>


        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>


</body>
</html>
