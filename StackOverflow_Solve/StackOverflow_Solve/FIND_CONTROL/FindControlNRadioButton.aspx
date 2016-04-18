<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StackOverflow_Solve.FIND_CONTROL.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../js/jquery.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $('#rblObject input').click(function () {
                var selectedValue = $("#rblObject input:radio:checked").val();
                alert('Selected Value: ' + selectedValue);
                if (selectedValue == "rblVloer") {
              
                $("#keuze").css({ display: "none" });
                } else {
                $("#keuze").css({ display: "" });
                }

            });
            
        });
    </script>
    <div id="object" style="position:absolute; top:300px;">
        <label>Kies een object:</label>
        <br />
        OnSelectedIndexChanged="rblObject_SelectedIndexChanged"
        <asp:RadioButtonList ID="rblObject" runat="server" Height="52px" ClientIDMode="Static">
            <asp:ListItem Value="rblVloer">Vloer</asp:ListItem>
            <asp:ListItem Value="rblKamer">Kamer</asp:ListItem>
        </asp:RadioButtonList>
    </div>
        <asp:Panel ID="keuze" runat="server" style="position:absolute; top:400px;" ClientIDMode="Static">
            <asp:Label ID="Label2" runat="server" Text="Maak je keuze:"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
            <asp:ListItem Value="rblVierkant">Vierkant</asp:ListItem>
            <asp:ListItem Value="rblKubus">Kubus</asp:ListItem>
        </asp:RadioButtonList>
        </asp:Panel>
</asp:Content>
