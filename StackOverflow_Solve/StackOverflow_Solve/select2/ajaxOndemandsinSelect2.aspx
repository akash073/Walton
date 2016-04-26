<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ajaxOndemandsinSelect2.aspx.cs"
    Inherits="StackOverflow_Solve.select2.ajaxOndemandsinSelect2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/select2.css" rel="stylesheet" type="text/css" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.0/jquery.js" type="text/javascript"></script>
    <script src="select2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            var myurl = 'http://localhost:1611/jQueryUI/Handler1.ashx';

            $("#ddlSelect").select2({
                ajax: {
                    url: myurl,
                    dataType: 'json',
                    quietMillis: 50,
                    data: function (term) {
                        return {
                            term: term
                        };
                    },
                    results: function (data) {
                        return {
                            results: $.map(data, function (item) {
                                return {
                                    text: item.text,
                                    id: item.id
                                };
                            })
                        };
                    }
                }
            });
            $('#attendee').click(function() {
                console.log($('#ddlSelect').val());
            });

        });

        
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <select id="Registration" class="itemSearch" style="width: 500px">
        </select>
        <asp:DropDownList ID="ddlSelect" runat="server" ClientIDMode="Static" Width="125">
        </asp:DropDownList>
    </div>
    <div>
        <asp:TextBox ID="attendee" runat="server" ClientIDMode="Static" Width="150px" OnClientClick="return false;"></asp:TextBox>
    </div>
    </form>
</body>
</html>
