<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Autocomplete.aspx.cs" Inherits="StackOverflow_Solve.telericUI.Autocomplete" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
     <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
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
        <input id="comboBox" style=" width: 500px;"/>
        <div id="result">
        </div>
        <div>
            <input id="suppliers"/> 
        </div>
    </div>
    </form>
    <script type="text/javascript">
        var webapiUrl = 'http://localhost:56628/api/SpareParts';
        var myurl = 'http://localhost:1611/jQueryUI/Handler1.ashx';
        $(function() {
            $("#comboBox").kendoComboBox({
                index: 0,
                dataTextField: "text",
                dataValueField: "id",
                filter: "contains",
                dataSource: {
                    transport: {
                        read: {
                            dataType: "json",
                            url: myurl
                        }
                    }
                }
            });
        });
//        $(document).ready(function () {
//            var webapiUrl = 'http://localhost:56628/api/SpareParts';
//            $("#autoComplete").kendoAutoComplete({
//                template: $("#headerTemplate").html(),
//                dataTextField: "name",
//                dataSource: {
//                    transport: {
//                        read: {
//                            dataType: "jsonp",
//                            url: webapiUrl
//                        }
//                    }
//                }
//            });
//        });
    </script>
   <%-- <script type="text/javascript">
        $(function () {
            var myurl = './Autocomplete.aspx/getSpareParts';
            var scriptUrl = '/WebService1.asmx/getSpareParts';
            var webapiUrl = 'http://localhost:56628/api/SpareParts';
            var items = new kendo.data.DataSource({

                transport: { read: { url: webapiUrl, type: "GET", dataType: "json", contentType: "application/json; charset=utf-8"
                }, parameterMap: function() {
                     return { value: $("#autocomplete").data("kendoAutoComplete").value() };
                } } 
            });
            var data = [
                { id: 1, name: "Apples" },
                { id: 2, name: "Oranges" }
            ];
            var jsonData;
            $.ajax({
                type: "POST",
                url: scriptUrl,
                data: JSON.stringify({ value: "1" }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (result) {
                    //alert("i am in success");

                    jsonData = result.hasOwnProperty('d') ? result.d : result;
                   
                    console.log(jsonData);
                    
//                    $("#autocomplete").kendoAutoComplete({
//                        dataTextField: "text",
////                        select: function (e) {
////                            var dataItem = this.dataItem(e.item.index());
////                            //output selected dataItem
////                            $("#result").html(kendo.stringify(dataItem)); // Bind html to see your selected text and value      
////                        },
//                        dataSource: {
//                            data: jsonData
//                        }
//                    });
                },
                failure: function (response) {
                    console.log("I am in failure");
                }
            });
            var autoComplete = $("#autocomplete").kendoAutoComplete({
                minLength: 3,
                separator: ", ",
                dataSource: jsonData,
                serverFiltering: true,
                dataTextField: "text"
                        }).data("kendoAutoComplete");
            //            var testData = [{ "id": 1, "text": "Horn -100/110cc" }, { "id": 2, "text": "Crankcase Cover Right Assy-Clutch Cover Cruize-Fusion 110" }, { "id": 3, "text": "Main Stand Gabrial Cruize-Fusion 110" }];
            
           
            
        });
    </script>--%>
</body>
</html>
