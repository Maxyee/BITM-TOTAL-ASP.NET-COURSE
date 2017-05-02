<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="SessionWebFormAsp.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="nameLabel" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="btnShow" runat="server" Text="Button" OnClick="btnShow_Click" />
    </div>
    </form>
</body>
</html>
