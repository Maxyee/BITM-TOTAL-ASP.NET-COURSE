<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="OddandEvenJavascript.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        
    </div>
    <script>
        var i = 20;
        while (i>0) {
            document.write(i);
            if (i%2 == 0) {
                document.write("number is evern" + i);
            } else {
                document.write("number is odd" + i);
            }
            i++;
        }
    </script>
</body>
</html>
