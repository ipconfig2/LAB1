<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="Lab1.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="lblHello"></asp:Label>
            <asp:Literal ID="litName" runat="server"></asp:Literal>
            <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Submit" />
            <asp:Label ID="lblHello" runat="server" Text="" Font-Bold="True" Font-Italic="True"></asp:Label>

        </div>
    </form>
</body>
</html>
