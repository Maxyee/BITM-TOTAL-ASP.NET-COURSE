<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FirstWebApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Hello :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
        <input id="Text1" type="text" />
        <asp:Button ID="btnButton" runat="server" Text="Show" OnClick="Button1_Click" />
        <hr/>
        <br/>
        <asp:Label ID="Label1" runat="server" Text="Label">MegLabel</asp:Label>
    </div>
        
    </form>
</body>
</html>
