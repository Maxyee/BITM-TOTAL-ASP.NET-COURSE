<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebCalculator.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <h1>Web Calculator</h1>
            <p>Firstnumber:</p><asp:TextBox ID="txtFirstNumber" runat="server"></asp:TextBox>
            <br/>
            <p>LastNumber:</p><asp:TextBox ID="txtLastNumber" runat="server"></asp:TextBox>
            <br/>
            <p>Result:</p><asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
            <br/>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnSubstract" runat="server" Text="Substract" OnClick="btnSubstract_Click" />
            <asp:Button ID="btnMultiply" runat="server" Text="Multiply" OnClick="btnMultiply_Click" />
            <asp:Button ID="btnDivide" runat="server" Text="Divide" OnClick="btnDivide_Click" />
        </center>
    </div>
    </form>
       
</body>
</html>
