<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Autocomplete.aspx.cs" Inherits="StackOverflow_Solve.telericUI.Autocomplete" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Kendo UI Snippet</title>
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
        <input id="autocomplete" />
        <div id="result">
        </div>
    </div>
    </form>
    <script type="text/javascript">
        $(function () {
            var myurl = './Autocomplete.aspx/getSpareParts';
            var scriptUrl = '/WebService1.asmx/getSpareParts';
            var items = new kendo.data.DataSource({

                transport: { read: { url: scriptUrl, type: "POST", dataType: "json" 
                }, parameterMap: function() {
                     return { value: $("#autocomplete").data("kendoAutoComplete").value() };
                } } 
            });
            var data = [
                { id: 1, name: "Apples" },
                { id: 2, name: "Oranges" }
            ];
            var autoComplete = $("#autocomplete").kendoAutoComplete({
                minLength: 3,
                separator: ", ",
                dataSource: items,
                serverFiltering: true,
                dataTextField: "text"
            }).data("kendoAutoComplete");
//            $.ajax({
//                type: "POST",
//                url: myurl,
//                data: JSON.stringify({value:"1"}),
//                contentType: "application/json; charset=utf-8",
//                dataType: "json",
//                success: function (result) {
//                    //alert("i am in success");
//                    console.log(result);

//                },
//                failure: function (response) {
//                    console.log("I am in failure");
//                }
//            });
        });
    </script>
</body>
</html>
