<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormObjectBasic.aspx.cs" Inherits="javascript_programming_basics.JavascriptObjectsAndPrototypes.WebFormObjectBasic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>  <script type="text/javascript" src="../../Scripts/jquery-1.8.2.js"></script>
        <script type="text/javascript">
            //for (var p in this) {
            //    console.log(p);  //this points to window
            //}
           
           //'use strict'
            $(document).ready(function () {
            //chapter 1
            //    var cat = { name: 'fluffy2', color: 'white' }
            //    console.log(cat.name);

            //    cat.age = 3;
            //    console.log(cat.age);

            //    cat.speak = function () { console.log('meeoow') }

            //    cat.speak();

                //chapter 2

                //function Cat(name,color) {
                //    this.name = name;
                //    this.color = color;
                //}

                //var cat = new Cat('fluffy','white');
                //console.log(cat['name']);

                //Object.defineProperty(cat, 'name', {writable:false})
                //console.log(Object.getOwnPropertyDescriptor(cat, 'name'));

                //chapter3 , prototype

                function Cat(name, color) {
                    this.name = name;
                    this.color = color;
                }

                var fluffy = new Cat("name", 'white');

                Cat.prototype.age = 3;
                console.log(Cat.prototype);
                console.log(fluffy.__proto__);

                
            });

         


        </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
