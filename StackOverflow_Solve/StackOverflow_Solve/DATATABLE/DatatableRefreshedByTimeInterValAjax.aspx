<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatatableRefreshedByTimeInterValAjax.aspx.cs" Inherits="StackOverflow_Solve.DATATABLE.DatatableRefreshedByTimeInterValAjax" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="jquery.dataTables.css" rel="stylesheet" type="text/css" />
    <script src="jquery-1.12.0.min.js" type="text/javascript"></script>
    <script src="jquery.dataTables.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function() {
            var $dataTable = $('#example1').DataTable({
                "ajax": 'DatatableRefreshedByTimeInterValAjax.aspx/GetBoxes', // just added this
//                "data": data,
//                "bDestroy": true,
//                "stateSave": true,
//                // the init function is called when the data table has finished loading/drawing
//                "init": function () {
//                    // now that the initial data has loaded we can start the timer to do the refresh
//                    setInterval(function () {
//                        $dataTable.ajax.reload();
//                    }, 30000);

//                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table id="example1"></table>
    </div>
    </form>
</body>
</html>
