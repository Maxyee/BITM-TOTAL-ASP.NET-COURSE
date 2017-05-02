<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AccountOperation.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: aquamarine">
        <center><h1>Account Operation</h1></center>
        <p>Account Creation:</p>
        <center>
            <table>
                <tr>
                    <td>Account Number:</td>
                    <td><asp:TextBox ID="txtAccountNumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Customer Name:</td>
                    <td><asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click"></asp:Button></td>
                </tr>
            </table>
        </center>
            <hr/>
        <p>Transaction:</p>
        <center>
            <table>
                <tr>
                    <td>Amount</td>
                    <td><asp:TextBox ID="txtAmount" runat="server"></asp:TextBox></td> 
                </tr>
                <tr>
                    <td><asp:Button ID="btnDeposite" runat="server" Text="Deposite" OnClick="btnDeposite_Click"></asp:Button></td>
                    <td><asp:Button ID="btnWithdraw" runat="server" Text="Withdraw"></asp:Button></td>
                </tr>
            </table>
            <asp:Button ID="btnReport" runat="server" Text="Report"></asp:Button>
        </center>
    </div>
        <br/>
        <hr/>
        <div style="background-color: blanchedalmond">
            <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
