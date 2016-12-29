<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAjax.aspx.cs" Inherits="javascript_programming_basics.JqueryFundamentals.WebFormAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script type="text/javascript" src="../../Scripts/jquery-1.8.2.js"></script>
        <script type="text/javascript">
            $(document).ready(function () {
                $.ajax({
                    type:'Get',
                    url: 'http://localhost:51782/api/values',
                    success: function (data) {
                        if (data != null) {
                            var content = "";
                            //for (var d in data) {
                            //    content += "<div>" + d + "</div>"
                            //}
                            $.each(data, function (n, value) {
                                content += "<div>" + value + "</div>"
                            });
                            $("#output").html(content);
                        }
                        else {
                            $("#output").html('empty');
                        }
                    }
                });
            });
        </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="output">
    
    </div>
    </form>
</body>
</html>
