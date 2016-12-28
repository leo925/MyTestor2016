<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormSelector.aspx.cs" Inherits="javascript_programming_basics.JqueryFundamentals.WebFormSelector" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <script type="text/javascript" src="../../Scripts/jquery-1.8.2.js"></script>
        <script type="text/javascript">
            $(document).ready(function () {
                var allInputs = $(":input");

                $("#txtOutput").val(allInputs.length);
                
            });
        </script>
</head>
<body>
    <form id="form1" >
    <div>
    <input type="button" value="click me" />

        <button value="button " >buton</button>
    </div>
        <div>
            <input type="text" id="txtOutput" />
        </div>
    </form>
</body>
</html>
