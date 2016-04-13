<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StackOverflow_Solve.WEBSERVICE.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../js/jquery.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            StackOverflow_Solve.WebService1.Sum([1,2],onSuccess);
            function onSuccess(result) {
                alert(result);
            } 
            $("#Button1").on("click", function (e) {
                e.preventDefault();
                Register();
            });

            function Register() {
                var params = {};
                params.a = [112,125];
                //params.b = 100;
                $.ajax({
                    type: "POST",
                    url: "http://localhost:1611/WebService1.asmx/Sum",
                    crossDomain: true,
                    data: JSON.stringify(params),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function(data) {
                        alert("SUCCESS="+data.d);
                    },
                    error: function(data) {
                        alert("error=" + data);
                    }
                });
            }
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" ClientIDMode="Static" runat="server" Text="Button" onclick="Button1_Click" />
    </div>
    <asp:scriptmanager ID="Scriptmanager1" runat="server">
        <Services>
            <asp:ServiceReference runat="server" Path="~/WebService1.asmx"/>

        </Services>
        
    </asp:scriptmanager>
    </form>
</body>
</html>

