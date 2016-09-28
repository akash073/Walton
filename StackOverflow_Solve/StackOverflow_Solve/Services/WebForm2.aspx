<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="WebForm2.aspx.cs" Inherits="StackOverflow_Solve.Services.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../Scripts/jquery-1.12.0.min.js" type="text/javascript"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <div class="row">
        //first radio button group
        <div class="col-md-1 col-xs-1 col-sm-1">
            &nbsp;</div>
        <div class="col-md-1 col-xs-1 col-sm-1 centerText">
            <input type="radio" name="pertanyaan1" value="1"><br>
            1<!--<br>Awful--></div>
        <div class="col-md-1 col-xs-1 col-sm-1 centerText">
            <input type="radio" name="pertanyaan1" value="2"><br>
            2</div>
        <div class="col-md-1 col-xs-1 col-sm-1 centerText">
            <input type="radio" name="pertanyaan1" value="3"><br>
            3</div>
        <div class="col-md-1 col-xs-1 col-sm-1 centerText">
            <input type="radio" name="pertanyaan1" value="4"><br>
            4</div>
        <div class="col-md-1 col-xs-1 col-sm-1 centerText">
            <input type="radio" name="pertanyaan1" value="5"><br>
            5<!--<br>Ok--></div>
        <div class="col-md-1 col-xs-1 col-sm-1 centerText">
            <input type="radio" name="pertanyaan1" value="6"><br>
            6</div>
        <div class="col-md-1 col-xs-1 col-sm-1 centerText">
            <input type="radio" name="pertanyaan1" value="7"><br>
            7</div>
        <div class="col-md-1 col-xs-1 col-sm-1 centerText">
            <input type="radio" name="pertanyaan1" value="8"><br>
            8</div>
        <div class="col-md-1 col-xs-1 col-sm-1 centerText">
            <input type="radio" name="pertanyaan1" value="9"><br>
            9</div>
        <div class="col-md-1 col-xs-1 col-sm-1 centerText">
            <input type="radio" name="pertanyaan1" value="10"><br>
            10<!--<br>Incridible--></div>
        <div class="col-md-1 col-xs-1 col-sm-1">
            &nbsp;</div>
    </div>
    <script>
        $(function () {

            $('input[type=radio]').on('click', function () {

                var value = $(this).attr('value');
                console.log(value);
                if ($(this).is(':checked')) {
                   // alert("it's checked");
                    console.log("it's checked");
                }
            });
        });
    </script>
</asp:Content>
