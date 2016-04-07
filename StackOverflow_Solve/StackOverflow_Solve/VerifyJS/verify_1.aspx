<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="verify_1.aspx.cs" Inherits="StackOverflow_Solve.VerifyJS.verify_1"  EnableEventValidation="false"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.js" type="text/javascript"></script>
    <%-- <script src="//code.jquery.com/ui/1.11.2/jquery-ui.js"></script>
<!-- Latest compiled and minified JavaScript -->
<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js"></script>--%>

   <%-- <script src="http://rawgit.com/jpillora/verifyjs/gh-pages/dist/verify.notify.min.js" type="text/javascript"></script>--%>
    <script type="text/javascript">
        $(function() {
            $('#Button1').on('click', function(e) {
                e.preventDefault();
                //alert('hi');
                __doPostBack('__Page', 'MyCustomArgument');
            });

        })
</script>
</head>
<body>
     <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" data-validate="required" runat="server"></asp:TextBox><br/>
        <asp:TextBox ID="TextBox2" data-validate="required" runat="server"></asp:TextBox><br/>
        <asp:Button ID="Button1" runat="server" Text="Button" 
            ClientIDMode="Static"   />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="" ></asp:Label>
    </form>
</body>
</html>
