<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="autocompletWithWebService.aspx.cs" Inherits="StackOverflow_Solve.telericUI.autocompletWithWebService" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://kendo.cdn.telerik.com/2015.3.1111/styles/kendo.common.min.css">
    <link rel="stylesheet" href="http://kendo.cdn.telerik.com/2015.3.1111/styles/kendo.rtl.min.css">
    <link rel="stylesheet" href="http://kendo.cdn.telerik.com/2016.1.412/styles/kendo.silver.min.css" />
    <link rel="stylesheet" href="http://kendo.cdn.telerik.com/2015.3.1111/styles/kendo.mobile.all.min.css">
    <script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
    <script src="http://kendo.cdn.telerik.com/2015.3.1111/js/kendo.all.min.js"></script>
    <link rel="stylesheet" href="http://kendo.cdn.telerik.com/2015.3.1111/styles/kendo.default.min.css">
    <script src="http://kendo.cdn.telerik.com/2015.3.1111/js/angular.min.js"></script>
    <script src="http://kendo.cdn.telerik.com/2015.3.1111/js/jszip.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input id="products" style="width: 250px" />
    </div>
    </form>
    <script type="text/javascript">
        $(function () {
            var scriptUrl = '/autocompletWithWebService.aspx/getSpareParts';
            var ds = { "foo": ["item 1", "item 2", "item 3"] };

            $("#products").kendoAutoComplete({
                filter: "contains",
                minLength: 3,
                dataSource: {
                    pageSize: 10,
                    transport: {
                        read: { url: scriptUrl,  dataType: "json", contentType: "application/json; charset=utf-8"
                        }
                    },
                    schema: {
                        data: "d"
                    }
                }
            })
        });
    </script>
</body>
</html>
