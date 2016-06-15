<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="abc.aspx.cs" Inherits="StackOverflow_Solve.WEBSERVICE.abc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <script type="text/javascript">
        $(function() {

            $('#btnAddNewUser').click(function(e) {
                e.preventDefault();
                //Make your ajax call
                var url = 'http://localhost:1915/Services/Customer/TestService.asmx/GetSapares';
                var params = {};
                params.parameter = "passing string data";
                $.ajax({
                    type: "GET",
                    url: url,
                    dataType: "jsonp",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify(params),
                    success: function(res) {
                        alert(res.d);
                    },
                    error: function(res) {
                    }
                });
            });

            function Function1() {
                alert("In Ajax Call");
                var params = {};
                params.parameter = "passing string data";
                $.ajax({
                    type: "POST",
                    url: "abc.aspx/MyFunction1",
                    dataType: "json",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify(params),
                    success: function(res) {
//                    $('#regularticker').html(res.d);
//                    //$('#futureticker').html(res.d);
//                    var d = new Date(); // for now
//                    $('#updateTime').html("Update at " + d.getHours() + ":" + d.getMinutes() + ":" + d.getSeconds());
//                    //alert(res.d.toString());
//                    alert(res);
                        alert(res.d);
                    },
                    error: function(res) {
                    }
                });
            }
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnAddNewUser" ClientIDMode="Static" CausesValidation="false" runat="server"
            Text="Add New User" Width="140px" />
    </div>
    </form>
</body>
</html>
