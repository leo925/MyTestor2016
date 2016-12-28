<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormFreePractise1.aspx.cs" Inherits="WebFormHtml.Html5Fundamentals.FreePractise.WebFormFreePractise1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="../../Scripts/jquery-1.8.2.js"></script>
</head>
<body>
    <form id="form1" runat="server" method="post">
    <div>
    <input type="color" />
        <input id="colors-box" list="colorList" />
        <datalist id="colorList">
            <option value="Blue"></option>
            <option value="Red"></option>
        </datalist>

        <input type="text"  placeholder="first and last " required/>
        <input type="number" max="50" min="5" step="2" />

        <input type="text" pattern="[a-zA-Z]{5,}" placeholder="username" maxlength="30" required />

        <div>
            <label>date:</label>
            <input type="date" autofocus />
        </div>
        <div>
            <input type="submit" value="ok" />
        </div>
        <div>
            <input type="search" />
        </div>
    </div>
    </form>
</body>
</html>
