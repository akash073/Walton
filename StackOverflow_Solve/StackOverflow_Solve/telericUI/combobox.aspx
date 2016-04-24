<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="combobox.aspx.cs" Inherits="StackOverflow_Solve.telericUI.combobox" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="kendo.common-material.min.css" />
    <link rel="stylesheet" href="kendo.material.min.css" />

    <script src="jquery.min.js"></script>
    <script src="kendo.all.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div id="example">
            <div class="demo-section k-content">
                <h4>ComboBox</h4>
                <input id="combobox" style="width: 100%"/>
            </div>
            <script type="text/javascript">
                $(document).ready(function () {
                    function onOpen() {
                        if ("kendoConsole" in window) {
                            console.log("event :: open");
                            
                        }
                    }

                    function onClose() {
                        if ("kendoConsole" in window) {
                            console.log("event :: close");
                        }
                    }

                    function onChange() {
                        if ("kendoConsole" in window) {
                            console.log("event :: change");
                        }
                    }

                    function onSelect(e) {
                        if ("kendoConsole" in window) {
                            var dataItem = this.dataItem(e.item.index());
                            alert('HI');
                            console.log("event :: select (" + dataItem.text + " : " + dataItem.value + ")");
                        }
                    };

                    function onDataBound(e) {
                        if ("kendoConsole" in window) {
                            console.log("event :: dataBound"+e);
                        }
                    };

                    function onFiltering(e) {
                        if ("kendoConsole" in window) {
                            console.log("event :: filtering"+e);
                        }
                    }

                    var data = [
                        { text: "Item 1", value: "x" },
                        { text: "Item 2", value: "y" },
                        { text: "Item 3", value: "z" }
                    ];

                    $("#combobox").kendoComboBox({
                        dataTextField: "text",
                        dataValueField: "value",
                        filter: "startswith",
                        dataSource: data,
                        select: onSelect,
                        change: onChange,
                        close: onClose,
                        open: onOpen,
                        filtering: onFiltering,
                        dataBound: onDataBound
                    });
                });
            </script>
        </div>



    </div>
    </form>
</body>
</html>
