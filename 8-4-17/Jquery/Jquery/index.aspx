<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Jquery.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  
    <div>
        <input type="submit" name="name" value="click" id="btn"/>
        <h1 id="msg">Hello Jquery</h1>
    </div>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script>
        //$(document).ready(function() {
        //    $("#btn").click(function() {
        //        //$("#msg").hide();
        //        $("#msg").hover(function() {
                    
        //        });
        //    });
        //});

        $(document).ready(function () {
            $("#btn").hover(function() {
                    $("#msg").hide();
                },
                function() {
                    $("#msg").show("3000");
                }
                );
            });
    </script>
</body>
</html>
