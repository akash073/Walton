<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimleModal.aspx.cs" Inherits="StackOverflow_Solve.Styles.SimleModal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/basic.css" rel="stylesheet" type="text/css" />
    <link href="../css/demo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
 
    <div id='content'>
		<div id='basic-modal'>
			<h3>Basic Modal Dialog</h3>
			<p>A basic modal dialog with minimal styling and no additional options. There are a few CSS properties set internally by SimpleModal, however, SimpleModal relies mostly on style options and/or external CSS for the look and feel.</p>
			<input type='button' name='basic' value='Demo' class='basic'/> or <a href='#' class='basic'>Demo</a>
		</div>
		
		<!-- modal content -->
		<div id="basic-modal-content">
			<h3>Basic Modal Dialog</h3>
			<p>For this demo, SimpleModal is using this "hidden" data for its content. You can also populate the modal dialog with an AJAX response, standard HTML or DOM element(s).</p>
			<p>Examples:</p>
			<p><code>$('#basicModalContent').modal(); // jQuery object - this demo</code></p>
			<p><code>$.modal(document.getElementById('basicModalContent')); // DOM</code></p>
			<p><code>$.modal('&lt;p&gt;&lt;b&gt;HTML&lt;/b&gt; elements&lt;/p&gt;'); // HTML</code></p>
			<p><code>$('&lt;div&gt;&lt;/div&gt;').load('page.html').modal(); // AJAX</code></p>
		
			<p><a href='http://www.ericmmartin.com/projects/simplemodal/'>More details...</a></p>
		</div>

		<!-- preload the images -->
		<div style='display:none'>
			<img src='~/img/basic/x.png' alt='' />
		</div>
	</div>
    </form>
    <!-- Load JavaScript files -->

    
    <script src="../js/jquery.js" type="text/javascript"></script>
    <script src="../js/jquery.simplemodal.js" type="text/javascript"></script>
    <script src="../js/basic.js" type="text/javascript"></script>
    


</body>
</html>
