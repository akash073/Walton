<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StackOverflow_Solve.jQueryUIAutocomplete.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <script src="jquery-2.1.1.js" type="text/javascript"></script>
    <script type="text/javascript" src="jquery.mockjax.js"></script>

    <script src="jquery.autocomplete.js" type="text/javascript"></script>
    <script type="text/javascript" src="countries.js"></script>
    <script type="text/javascript" src="demo.js"></script>
    <script>
        $(function () {
            var myurl = 'WebForm1.aspx/getSpareParts';
            au
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input type="text" name="country" id="autocomplete"/>
    </div>
    <div>
            <input type="text" name="country" id="autocomplete-custom-append" style="float: left;"/>
            <div id="suggestions-container" style="position: relative; float: left; width: 400px; margin: 10px;"></div>
        </div>
    </form>
</body>
</html>
