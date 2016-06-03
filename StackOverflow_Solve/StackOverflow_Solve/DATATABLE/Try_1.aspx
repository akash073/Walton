<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Try_1.aspx.cs" Inherits="StackOverflow_Solve.DATATABLE.Try_1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles/jquery.dataTables.min.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/buttons.dataTables.min.css" rel="stylesheet" type="text/css" />
    <script src="../Scripts/jquery-1.12.0.min.js" type="text/javascript"></script>
    <script src="../Scripts/jquery.dataTables.min.js" type="text/javascript"></script>
    <script src="../Scripts/dataTables.buttons.min.js" type="text/javascript"></script>
    <script src="../Scripts/buttons.flash.min.js" type="text/javascript"></script>
    <script src="../Scripts/jszip.min.js" type="text/javascript"></script>
    <script src="../Scripts/pdfmake.min.js" type="text/javascript"></script>
    <script src="../Scripts/vfs_fonts.js" type="text/javascript"></script>
    <script src="../Scripts/buttons.html5.min.js" type="text/javascript"></script>
    <script src="../Scripts/buttons.print.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $('#GridView1').dataTable({
                dom: 'Bfrtip',
                buttons: [{
                    extend: 'excelHtml5',
                    title: 'Location Report'
                }]
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <a href="https://datatables.net/extensions/buttons/examples/html5/simple.html">link</a>
    </div>
    <div class="container">
        <asp:GridView ID="GridView1" ClientIDMode="Static" runat="server" AutoGenerateColumns="False"
            DataKeyNames="IssueID" DataSourceID="SqlDataSource1" class="display nowrap" CellSpacing="0"
            Width="100%">
            <Columns>
                <asp:BoundField DataField="IssueID" HeaderText="IssueID" InsertVisible="False" ReadOnly="True"
                    SortExpression="IssueID" />
                <asp:BoundField DataField="IssueName" HeaderText="IssueName" SortExpression="IssueName" />
                <asp:BoundField DataField="IssueDesc" HeaderText="IssueDesc" SortExpression="IssueDesc" />
                <asp:BoundField DataField="IssueType" HeaderText="IssueType" SortExpression="IssueType" />
                <asp:BoundField DataField="IssueCatagory" HeaderText="IssueCatagory" SortExpression="IssueCatagory" />
                <asp:CheckBoxField DataField="IsActive" HeaderText="IsActive" SortExpression="IsActive" />
                <asp:BoundField DataField="AddedBy" HeaderText="AddedBy" SortExpression="AddedBy" />
                <asp:BoundField DataField="AddedDate" HeaderText="AddedDate" SortExpression="AddedDate" />
                <asp:BoundField DataField="UpdatedBy" HeaderText="UpdatedBy" SortExpression="UpdatedBy" />
                <asp:BoundField DataField="UpdatedDate" HeaderText="UpdatedDate" SortExpression="UpdatedDate" />
                <asp:TemplateField HeaderText="SelectAction" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg">
                    <ItemTemplate>
                        <%--<asp:Button ID="btnTvIndoorConfirmationConfirmed" runat="server" ClientIDMode="Static"
                            CssClass="btn btn-success btn-xs" Text="Confirm" ToolTip="Apply"></asp:Button>--%>
                       <%-- <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1">
                        </asp:GridView>--%>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WSMSConnectionString %>"
            SelectCommand="SELECT * FROM [Issues]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
