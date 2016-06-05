<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropdownListImages.aspx.cs"
    Inherits="StackOverflow_Solve.KendoUI.DropdownListImages" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!DOCTYPE html>
<html>
<head>
    <base href="http://demos.telerik.com/kendo-ui/dropdownlist/remotedatasource">
    <style>
        html
        {
            font-size: 14px;
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
    <title></title>
    <link rel="stylesheet" href="//kendo.cdn.telerik.com/2016.2.504/styles/kendo.common-material.min.css" />
    <link rel="stylesheet" href="//kendo.cdn.telerik.com/2016.2.504/styles/kendo.material.min.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
    <script src="http://kendo.cdn.telerik.com/2016.1.112/js/kendo.all.min.js"></script>
    <link rel="stylesheet" href="http://kendo.cdn.telerik.com/2016.1.112/styles/kendo.common.min.css">
    <link rel="stylesheet" href="http://kendo.cdn.telerik.com/2016.1.112/styles/kendo.rtl.min.css">
    <link rel="stylesheet" href="http://kendo.cdn.telerik.com/2016.1.112/styles/kendo.default.min.css">
    <link rel="stylesheet" href="http://kendo.cdn.telerik.com/2016.1.112/styles/kendo.mobile.all.min.css">
    <script src="http://kendo.cdn.telerik.com/2016.1.112/js/angular.min.js"></script>
    <script src="http://kendo.cdn.telerik.com/2016.1.112/js/jszip.min.js"></script>
</head>
<body>
    <div id="example">
        <div class="demo-section k-content">
            <h4>
                Products</h4>
            <input id="products" style="width: 100%" />
        </div>
        <script>
                $(document).ready(function() {
                    $("#products").kendoDropDownList({
                        dataTextField: "ItemName",
                        dataValueField: "Id",
                        dataSource: {
                            transport: {
                                read: {
                                    dataType: "json",
                                    url: "http://localhost:1611/Services/SpareInfos.asmx/GetDropDownListBindings",
                                }
                            }
                        }
                    });
                });
        </script>
    </div>
</body>
</html>
