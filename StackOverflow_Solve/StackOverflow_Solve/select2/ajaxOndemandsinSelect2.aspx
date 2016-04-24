<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ajaxOndemandsinSelect2.aspx.cs"
    Inherits="StackOverflow_Solve.select2.ajaxOndemandsinSelect2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/select2.css" rel="stylesheet" type="text/css" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.0/jquery.js" type="text/javascript"></script>
    <script src="js/select2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            var myurl = 'ajaxOndemandsinSelect2.aspx/getSpareParts';
            var attendeeUrl = '../WebService1.asmx/getSpareParts';
            var pageSize = 20;

            $('#ddlSelect').select2({
                placeholder: 'Enter name',
                //Does the user have to enter any data before sending the ajax request
                minimumInputLength: 0,
                allowClear: true,

                ajax: {
                    //How long the user has to pause their typing before sending the next request
                    quietMillis: 150,
                    //The url of the json service
                    url: attendeeUrl,
                    dataType: 'json',
                    type: "POST",
                    contentType: "application/json; charset-utf-8",
                    //Our search term and what page we are on
                    data: function(term) {
                        return JSON.stringify(term);
                    },
//                    processResults: function(data, page) {
//                        var results = [];
//          $.each(data.d, function( item){
//            results.push({
//              id: item.id,
//              text: item.text
//            });
//          });
//          return {
//              results: results
//          };
//                    },

                    processResults: function(data) {
                        var results = [];
                        $.each(data, function(index, account) {
                            results.push({
                                id: account.id,
                                text: account.test
                            });
                        });

                        return {
                            results: results
                        };
                    },
                },
                id: function(e) { return e.id; },
                
        });
            //            $("#txtSerach").select2({
            //                ajax: {
            //                    url: "https://api.github.com/search/repositories",
            //                    dataType: 'json',
            //                    delay: 250,
            //                    data: function (params) {
            //                        return {
            //                            q: params.term, // search term
            //                            page: params.page
            //                        };
            //                    },
            //                    processResults: function (data, params) {
            //                        // parse the results into the format expected by Select2
            //                        // since we are using custom formatting functions we do not need to
            //                        // alter the remote JSON data, except to indicate that infinite
            //                        // scrolling can be used
            //                        params.page = params.page || 1;

            //                        return {
            //                            results: data.items,
            //                            pagination: {
            //                                more: (params.page * 30) < data.total_count
            //                            }
            //                        };
            //                    },
            //                    cache: true
            //                },
            //                escapeMarkup: function (markup) { return markup; }, // let our custom formatter work
            //                minimumInputLength: 1,
            //              //  templateResult: formatRepo, // omitted for brevity, see the source of this page
            //               // templateSelection: formatRepoSelection // omitted for brevity, see the source of this page
            //                initSelection: function (element, callback) {
            //                    //var elementText = $(element).attr('data-init-text');
            //                    callback({ "text": "", "id": "" });
            //                }
            //            });
        });

        
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <select id="Registration" class="select">
        </select>
        <asp:DropDownList ID="ddlSelect" runat="server" ClientIDMode="Static" Width="125">
        </asp:DropDownList>
    </div>
    <div>
        <asp:TextBox ID="attendee" runat="server" ClientIDMode="Static" Width="150px" OnClientClick="return false;"></asp:TextBox>
    </div>
    </form>
</body>
</html>
