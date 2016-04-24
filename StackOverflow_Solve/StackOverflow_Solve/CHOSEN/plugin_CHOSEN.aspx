<%@ Page Language="C#" AutoEventWireup="true" CodeFile="plugin_CHOSEN.aspx.cs" Inherits="DATATABLE_plugin_CHOSEN" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="jquery-ui.css" rel="stylesheet" type="text/css" />
    <link href="style.css" rel="stylesheet" type="text/css" />
    <link href="prism.css" rel="stylesheet" type="text/css" />
    <link href="chosen.css" rel="stylesheet" type="text/css" />
<%--    <script src="../Scripts/jquery-2.1.4.min.js" type="text/javascript"></script>--%>
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
<script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
    <script src="chosen.jquery.js" type="text/javascript"></script>
    <script src="prism.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            var myurl = 'ajaxOndemandsinSelect2.aspx/getSpareParts/';
            $(".chzn-select").chosen();
            $('.chzn-select').autocomplete({
                minLength: 3,
                source: function (request, response) {
                    $.ajax({
                        url: myurl + request.term,
                        dataType: "json",
                        beforeSend: function () { $('ul.chosen-results').empty(); $("#CHOSEN_INPUT_FIELDID").empty(); }
                    }).done(function (data) {
                        response($.map(data, function (item) {
                            $('#CHOSEN_INPUT_FIELDID').append('<option value="blah">' + item.name + '</option>');
                        }));

                        $("#CHOSEN_INPUT_FIELDID").trigger("chosen:updated");
                    });
                }
            });
        });
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<ion-view view-title="Profile">
<ion-content class="padding">

<div>
    <label class="item item-input">
        <div class="input-label">Enter Your Option</div>
            <select class="chzn-select"  name="faculty" style="width:1000px;">
                <option value="Option 2.1">Option 2.1</option>
                <option value="Option 2.2">Option 2.2</option>
                <option value="Option 2.3">Option 2.3</option>
            </select>   
    </label>
</div>
</ion-content>
</ion-view> 
    </div>
    </form>
</body>
</html>
