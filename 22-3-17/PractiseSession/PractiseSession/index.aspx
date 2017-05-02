<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PractiseSession.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 281px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color:wheat">
        <center>
            <h1 style="color:skyblue">Person Information</h1>
            <table style="margin-left: 0px">
                <tr>
                    <td>First Name:</td>
                    <td class="auto-style1"><asp:TextBox ID="txtFirst" runat="server" Width="280px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Middle Name:</td>
                    <td class="auto-style1"><asp:TextBox ID="txtMiddle" runat="server" Width="276px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td class="auto-style1"><asp:TextBox ID="txtLast" runat="server" Width="284px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td class="auto-style1"><asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" /></td>
                </tr>
                <tr>
                    <td>Full Name:</td>
                    <td class="auto-style1"><asp:TextBox ID="txtFull" runat="server" Width="278px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Reverse Name: </td>
                    <td class="auto-style1"><asp:TextBox ID="txtReverse" runat="server" Width="284px"></asp:TextBox></td>
                </tr>
            
            </table>
        </center>
    </div>
    </form>
</body>
</html>
