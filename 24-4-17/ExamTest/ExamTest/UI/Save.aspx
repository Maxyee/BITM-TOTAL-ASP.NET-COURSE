<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Save.aspx.cs" Inherits="ExamTest.UI.Save" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 256px">
    <form id="form1" runat="server">
    <center>    
            <div style="border:2px solid black">
                  <h1>Save Page</h1>
                    <table>
                        <tr>
                            <td>Product Code</td>
                            <td><asp:TextBox ID="txtProductCode" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Description</td>
                            <td><asp:TextBox ID="txtDescription" TextMode="multiline" Columns="50" Rows="5" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Quantity</td>
                            <td><asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><a href="Display.aspx">Go Display Page</a></td>
                            <td><asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"></asp:Button></td>
                        </tr>
                    </table>
                    <asp:Label ID="msgLabel" runat="server" Text="Label"></asp:Label>
            </div>
     </center>
    </form>
    
</body>
</html>
