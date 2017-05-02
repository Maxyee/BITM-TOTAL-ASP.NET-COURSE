<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SessionWebFormAsp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>name:</h1>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br/>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        <br/>
        <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
    </div>
        <asp:Label ID="nameLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
