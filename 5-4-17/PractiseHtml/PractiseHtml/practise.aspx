<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="practise.aspx.cs" Inherits="PractiseHtml.practise" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Practise</title>
    <style>
        .top {
            
            height: 300px;
            width: 300px;
            background-color: red; 
            border: 5px solid black;
        }
        .middle {
            height: 200px;
            width: 200px;
            background-color: green;
            margin-top: 10px;
            margin-left: 20px;
            margin-right: 5px;
            margin-bottom: 10px;
        }
        .last{
            height: 100px;
            width: 100px;
            background-color: blue;
            margin-top: 20px;
            margin-left: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="top">
        <div class="middle">
            <div class="last">
                <h1>content</h1>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
