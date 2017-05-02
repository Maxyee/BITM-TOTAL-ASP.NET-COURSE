<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web_Design.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Practise Design</title>
    <style>
        .box {
            height: 300px;
            width: 300px;
            background-color: red;
            margin-left: 50px;
            margin-top: 50px;
            padding-top: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>How to make a table</h1>
    <div>
        <table>
            <tr>
                <th>Name</th>
                <th>Id</th>
                <th>Address</th>
            </tr>
            <tr>
                <td>Shimul</td>
                <td>12</td>
                <td border="1">
                    <th>Dist</th>
                    <th>Vill</th>
                </td>
            </tr>
        </table>
    </div>
    <h1>How to make a List??  and how many of them.....</h1>
        <ul style="list-style-type: circle">
            <li>Dhaka</li>
            <li>Rajshahi</li>
            <li>Sylhet</li>
            <li>Chittagong</li>
        </ul>
        <dl>
            <dt>CSE</dt>
            <dd>Loren Ipsum loren do hum to kama soo</dd>
            <dt>EEE</dt>
            <dd>Loren Ipsum loren do hum to kama sooo</dd>
        </dl>
    <h1>How to make a div </h1>
        <div class="box">
            <h1>Hello World</h1>
        </div>
    </form>
</body>
</html>
