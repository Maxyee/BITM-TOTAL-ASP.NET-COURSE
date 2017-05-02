<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JavascriptOOP.aspx.cs" Inherits="JavaScriptOOP.JavascriptOOP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
    
    </div>
    <script src="Person.js"></script>
    <script>
        

        var Person = new person1("Julhas", "Hossain", "Mohon");
        var Person = new person2("Jannatul", "Ferdus", "Tushi");

        var PersonList = [person1, person2];
        Console.log(person1.GetFullName());
        Console.log(person1.FirstName);
    </script>
</body>
</html>
