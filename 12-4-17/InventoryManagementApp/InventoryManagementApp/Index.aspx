<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="InventoryManagementApp.Index" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Title of the document</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <asp:Label ID="txtMeg" runat="server" Text="Label"></asp:Label>
            <tr>
                <td>Product Code</td>
                <td><asp:TextBox ID="txtCode" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Product Name</td>
                <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Unit Price</td>
                <td><asp:TextBox ID="txtUnit" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Quantity</td>
                <td><asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></td>
                <td><asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click"/></td>
            </tr>
        </table>
    </div>
        <asp:GridView ID="productView" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
