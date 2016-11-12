<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NoThings.aspx.cs" Inherits="StackOverflow_Solve.Others.NoThings" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="~/Scripts/jquery-1.12.0.min.js" type="text/javascript"></script>
    <script>
       $(function() {
           alert('Jquery');
       })
     </script>
</head>
<body>
    <form id="form1" runat="server">
    <input type="checkbox" checked id="chk1"  />
<input type="checkbox" checked id="chk2"  />
<input type="checkbox" checked id="chk3"  />
<input type="checkbox" checked id="chk4"  />

<input type="text" id="txt1" disabled="disabled" />
<input type="text" id="txt2" disabled="disabled" />
<input type="text" id="txt3" disabled="disabled" />
<input type="text" id="txt4" disabled="disabled" />


    </form>
</body>
</html>
