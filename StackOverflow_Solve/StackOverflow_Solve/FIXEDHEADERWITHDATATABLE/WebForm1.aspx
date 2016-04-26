<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StackOverflow_Solve.FIXEDHEADERWITHDATATABLE.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="../Styles/jquery.dataTables.min.css" rel="stylesheet" type="text/css" />
        <link href="https://cdn.datatables.net/fixedheader/3.1.1/css/fixedHeader.dataTables.min.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/buttons.dataTables.min.css" rel="stylesheet" type="text/css" />
    <script src="../Scripts/jquery-1.12.0.min.js" type="text/javascript"></script>
    <script src="../Scripts/jquery.dataTables.min.js" type="text/javascript"></script>
    <script src="../Scripts/dataTables.buttons.min.js" type="text/javascript"></script>
    <script src="../Scripts/buttons.flash.min.js" type="text/javascript"></script>
    <script src="../Scripts/jszip.min.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/fixedheader/3.1.1/js/dataTables.fixedHeader.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function() {
//            $('#GridView1').dataTable({
//                "bPaginate": false,
//                fixedHeader: true
            //            });
            var table = $('#GridView1').DataTable({
                 bPaginate: false,
            });

           var data= new $.fn.dataTable.FixedHeader(table, {
               // options
              
            });

        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" ClientIDMode="Static" 
            CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
