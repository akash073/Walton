<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DatatableExample.aspx.cs" Inherits="DATATABLE_DatatableExample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <link href="../Styles/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/jquery.dataTables.css" rel="stylesheet" type="text/css" />
    <script src="../Scripts/jquery-2.1.4.min.js" type="text/javascript"></script>
    <script src="../Scripts/bootstrap.js" type="text/javascript"></script>
    <script src="../Scripts/dataTables.bootstrap.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <script type="text/javascript">
        $(function() {
            $('#GridView1').dataTable();
            //$("#grdvStartJob").dataTable();
        })
    </script>
    <p>
        <br />
        <asp:GridView ID="GridView1" runat="server" ClientIDMode="Static">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:WSMSConnectionString %>" 
            SelectCommand="SELECT * FROM [Log]"></asp:SqlDataSource>
    </p>
    <p>
    </p>
</asp:Content>

