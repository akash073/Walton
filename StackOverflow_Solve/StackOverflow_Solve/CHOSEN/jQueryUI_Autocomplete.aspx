<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jQueryUI_Autocomplete.aspx.cs"
    Inherits="StackOverflow_Solve.CHOSEN.jQueryUI_Autocomplete" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="jquery-ui.css" rel="stylesheet" type="text/css" />
    <link href="style.css" rel="stylesheet" type="text/css" />
    <link href="prism.css" rel="stylesheet" type="text/css" />
    <link href="chosen.css" rel="stylesheet" type="text/css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
    <script>
        $(function () {
            var availableTags = [
      "ActionScript",
      "AppleScript",
      "Asp",
      "BASIC",
      "C",
      "C++",
      "Clojure",
      "COBOL",
      "ColdFusion",
      "Erlang",
      "Fortran",
      "Groovy",
      "Haskell",
      "Java",
      "JavaScript",
      "Lisp",
      "Perl",
      "PHP",
      "Python",
      "Ruby",
      "Scala",
      "Scheme"
    ];
            $("#tags").autocomplete({
                source: availableTags
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="ui-widget">
            <label for="tags">
                Tags:
            </label>
            <input id="tags">
        </div>
    </div>
    </form>
</body>
</html>
