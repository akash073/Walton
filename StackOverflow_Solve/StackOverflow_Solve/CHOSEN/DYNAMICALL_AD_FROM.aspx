<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DYNAMICALL_AD_FROM.aspx.cs"
    Inherits="DATATABLE_DYNAMICALL_AD_FROM" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-2.1.4.min.js" type="text/javascript"></script>
</head>
<body>
    <body>
        <form id="_frmMain" runat="server">
        <asp:FormView ID="_fvMain" runat="server" DefaultMode="Edit" Width="100%">
            <EditItemTemplate>
                <asp:Table ID="Table1" CssClass="sub" runat="server">
                    <asp:TableRow CssClass="tr_button_list">
                        <asp:TableCell ColumnSpan="3">
                            <asp:Button ID="_btnOk" ClientIDMode="Static" Text="Ok" runat="server" CssClass="butt_orange_small"
                                OnClientClick="javascript: return ShowSection('section1');" />
                            <asp:Button ID="_btnCancel" ClientIDMode="Static" Text="Cancel" runat="server" CssClass="butt_orange_small"
                                OnClientClick="javascript: return ShowSection('section2');" />
                                </asp:TableCell>
                                </asp:TableRow>
               </asp:Table>
            </EditItemTemplate>
        </asp:FormView>
        </form>
    </body>
</html>
