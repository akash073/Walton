<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="StackOverflow_Solve.Others.GridView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <style>
        .btnHidden {
            display: none !important;
        }
    </style>
    <script>
        $(function() {
            $('input[type="submit"]').click(function (e) {
                e.preventDefault();
                //Iterate row to do somthing


                var userid = $(this).closest('tr').find('td:eq(0)').text();
                alert(userid);
            });
            $("#grdvShowUsers tr").each(function (index) {
                //Excluding Header
                if (index != 0) {

                    var userid = $(this).find('td:eq(0)').text();
                   // if (userid === '11614') {
                        $(this).find('input[type="submit"]').addClass("btnHidden");
                    //}
                }
            });
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div >
      <input id="Button1" type="button" runat="server" value="Invoice" style="width: 80px;" />
    </div>
    <div>
       
        
    </div>
    <div>
        <asp:GridView ID="grdvShowUsers" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="UserID"
            onrowdatabound="grdvShowUsers_RowDataBound" ClientIDMode="Static">
            <Columns>
                <asp:BoundField DataField="UserID" HeaderText="UserID" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" />
                 <asp:TemplateField>
                      <HeaderTemplate>
                          ColumnName
                      </HeaderTemplate>
                      <ItemTemplate>
                          <asp:Button  ID="btnHidden" runat="server" Text="Button" ClientIDMode="Static" />
                      </ItemTemplate>
                 </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
