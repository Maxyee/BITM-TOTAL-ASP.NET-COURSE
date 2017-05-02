<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CustomerQueueWeb.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div class="left">
             <h3>Enqueue Customer:</h3>
             <table>
                 <tr>
                     <td>Name:</td>
                     <td><asp:TextBox ID="txtEncomName" runat="server"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Complain:</td>
                     <td><asp:TextBox ID="txtEncomComplain" runat="server"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td></td>
                     <td><asp:Button ID="btnEnqueue" runat="server" Text="Enqueue" /></td>
                 </tr>
             </table>
         </div>
        <div class="right">
            <h3>Dequeue Customer:</h3>
             <table>
                 <tr>
                     <td>Serial No:</td>
                     <td><asp:TextBox ID="txtDeSerial" runat="server"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Name:</td>
                     <td><asp:TextBox ID="txtDeName" runat="server"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Complain</td>
                     <td><asp:TextBox ID="txtDeComplain" runat="server"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td></td>
                     <td><asp:Button ID="btnDequeue" runat="server" Text="Dequeue" /></td>
                 </tr>
             </table>
        </div>
        <div>
            <table>
                <tr>
                    <td>Serial No:</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Complain</td>
                    <td></td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
