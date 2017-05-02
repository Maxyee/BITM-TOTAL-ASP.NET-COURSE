<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="salaryCalculator.aspx.cs" Inherits="WebSalaryCalculator.salaryCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <h1>Salary Calculator</h1>
            <p>Employee Name: </p>
            <asp:TextBox ID="txtEmployee" runat="server"></asp:TextBox>
            <br/>
            <p>Basic Amount: </p>
            <asp:TextBox ID="txtBasicAmount" runat="server"></asp:TextBox>
            <br/>
            <p>House Rent: </p>
            <asp:TextBox ID="txtHouseRent" runat="server"></asp:TextBox>
            <br/>
            <p>Medical Allowance: </p>
            <asp:TextBox ID="txtMedicalRent" runat="server"></asp:TextBox>
            <br/><br/>
            <asp:Button ID="btnResult" runat="server" Text="Show Me Salary" OnClick="btnResult_Click"></asp:Button>
            <br/>
            <p>Total Salary:</p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
        </center>
    </div>
    </form>
</body>
</html>
