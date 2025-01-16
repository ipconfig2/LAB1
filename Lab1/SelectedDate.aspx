<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectedDate.aspx.cs" Inherits="Lab1.SelectedDate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Date</title>
    
</head>
<body>
    <h1>My First ASP Web Page</h1>
    <asp:Label ID="lblDisplay" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="lblTest" runat="server" Text="Label"></asp:Label>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>
            <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Last Name: "></asp:Label>
            <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <asp:Button ID="Button1" runat="server" Text="Submit" />
            <asp:Button ID="Button2" runat="server" Text="Clear" />
        </div>
    </form>
</body>
</html>
