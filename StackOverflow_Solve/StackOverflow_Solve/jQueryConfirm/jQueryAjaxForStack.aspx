<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jQueryAjaxForStack.aspx.cs" Inherits="StackOverflow_Solve.jQueryAjax.jQueryAjaxForStack" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="jquery-confirm.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery.js" type="text/javascript"></script>
    <script src="jquery-confirm.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function() {
            $.confirm({
                text: "Are you sure you want to delete ?",
                confirm: function () {
                    console.log('confirm');
                },
                cancel: function () {
                    $.confirm({
                        text: "We are going to delete ?",
                        confirm: function () {
                            console.log('x->confirm');
                        },
                        cancel: function () {
                            console.log('x->cancel');
                        }
                    });
                }
            });
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
