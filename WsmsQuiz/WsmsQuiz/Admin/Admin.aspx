<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WsmsQuiz.Admin.Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../Scripts/jquery-1.10.2.js"></script>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/default.css" rel="stylesheet" />
    <script src="../Scripts/zebra_datepicker.js"></script>
    <link href="../Content/jsgrid.css" rel="stylesheet" />
    <link href="../Content/jsgrid-theme.css" rel="stylesheet" />
    <script src="../Scripts/jsgrid.js"></script>
    <link href="../Content/jquery.alerts.css" rel="stylesheet" />
    <script src="../Scripts/jquery.alerts.js"></script>
    <link href="../Content/parsley.css" rel="stylesheet" />
    <script src="../Scripts/parsley.js"></script>
    <script type="text/javascript">
        
        $(function () {
            // alert('HI');
            $('#txtStartDate,#txtEndDate').Zebra_DatePicker();
            var clients = [
                { "Name": "Otto Clay", "Age": 25, "Country": 1, "Address": "Ap #897-1459 Quam Avenue", "Married": false },
                { "Name": "Connor Johnston", "Age": 45, "Country": 2, "Address": "Ap #370-4647 Dis Av.", "Married": true },
                { "Name": "Lacey Hess", "Age": 29, "Country": 3, "Address": "Ap #365-8835 Integer St.", "Married": false },
                { "Name": "Timothy Henson", "Age": 56, "Country": 1, "Address": "911-5143 Luctus Ave", "Married": true },
                { "Name": "Ramona Benton", "Age": 32, "Country": 3, "Address": "Ap #614-689 Vehicula Street", "Married": false }
            ];

            var countries = [
                { Name: "", Id: 0 },
                { Name: "United States", Id: 1 },
                { Name: "Canada", Id: 2 },
                { Name: "United Kingdom", Id: 3 }
            ];

            $("#jsGrid").jsGrid({
                
                width: "100%",
                height: "400px",

                inserting: true,
                editing: true,
                sorting: true,
                paging: true,

                // data: clients,

                //fields: [
                //    { name: "Name", type: "text", width: 150, validate: "required" },
                //    { name: "Age", type: "number", width: 50 },
                //    { name: "Address", type: "text", width: 200 },
                //    { name: "Country", type: "select", items: countries, valueField: "Id", textField: "Name" },
                //    { name: "Married", type: "checkbox", title: "Is Married", sorting: false },
                //    { type: "control" }
                //],
                fields: [
                    { name: "QuestionName", type: "text", width: 150, validate: "required" },
                    { name: "Answer1", type: "text", width: 15 },
                    { name: "Answer2", type: "text", width: 15},
                    { name: "Answer3", type: "text", width: 15 },
                    { name: "Answer4", type: "text", width: 15 },
                    { name: "Answer5", type: "text", width: 15 },
                    { type: "control" }


                ],
                onItemInserting: function(args) {
                    var insertedData = args.item;
                    console.log(insertedData);
                    args.cancel = true;
                    alert("Specify the name of the item!");
                   
                    //var url = 'Admin.aspx/GetGridData';
                    //$.ajax({
                    //    type: "POST",
                    //    url: url,
                    //    dataType: "json",
                    //    contentType: "application/json; charset=utf-8",
                    //    data: JSON.stringify ({'jsGridData': insertedData }),
                    //    success: function (res) {
                    //        console.log(res.d);
                    //        alert('The job has been inserted successfully');
                    //    },
                    //    error: function (res) {
                    //    }
                    //});
                    
                },
                onItemInserted: function(args) {
                    console.log(args);

                },
            });
        })
    </script>
    <div class="container" data-parsley-validate="">
        <div class="row">
            <br />
        </div>
        <div class="row">
           <%-- <div class="col-lg-2"></div>--%>
            <div class="col-lg-2">
                Quiz Name:
            </div>
            <div class="col-lg-4">
                <asp:TextBox ID="txtQuizName" runat="server" ClientIDMode="Static" TextMode="MultiLine" CssClass="form-control" data-parsley-trigger="change" required=""></asp:TextBox>
            </div>
        </div>
        <br />
        <br />
        <div class="row">

            <div class="col-lg-2">
                Start Date
            </div>
            <div class="col-lg-4">
                <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" Width="360px"></asp:TextBox>
            </div>
        </div>
        <br/>
        <div class="row">

            <div class="col-lg-2">
                End Date
            </div>
            <div class="col-lg-4">
                <asp:TextBox ID="txtEndDate" runat="server" ClientIDMode="Static" Width="360px"></asp:TextBox>
            </div>
        </div>
        
        <div class="row">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Add Question</h3>
                </div>

                <div class="panel-body">
                    <%-- Added question here --%>
                    <%--<div id="jsGrid"></div>--%>
                     <div id="jsGrid"></div>

                </div>
            </div>
        </div>
        <div class="row">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" ClientIDMode="Static" CssClass="btn btn-danger"/>
        </div>

    </div>
</asp:Content>
