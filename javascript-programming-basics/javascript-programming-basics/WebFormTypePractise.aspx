<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTypePractise.aspx.cs" Inherits="javascript_programming_basics.practise.WebFormTypePractise" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <script type="text/javascript" src="../../Scripts/jquery-1.8.2.js"></script>
        <script type="text/javascript">
            var d = 10;


            function bar()
            {
                return d;
            }

            function Foo(b)
            {
                return b + 5;
              
            }

            $(document).ready(function () {
                var r = Foo(bar);


            });
        </script>
    <div>
    <input type="checkbox" value="haha" /><label >haha</label>
    </div>
    </form>
</body>
</html>
