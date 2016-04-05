<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirm_SimpleModal.aspx.cs" Inherits="StackOverflow_Solve.Styles.Confirm_SimpleModal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/basic.css" rel="stylesheet" type="text/css" />
    <link href="../css/demo.css" rel="stylesheet" type="text/css" />
    <link href="../css/confirm.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id='container'>
	<div id='logo'>
		<h1>Simple<span>Modal</span></h1>
		<span class='title'>A Modal Dialog Framework Plugin for jQuery</span>
	</div>
	<div id='content'>
		<div id='confirm-dialog'>
			<h3>Confirm Override</h3>
			<p>A modal dialog override of the JavaScript confirm function. Demonstrates the use of the <code>onShow</code> callback as well as how to display a modal dialog confirmation instead of the default JavaScript confirm dialog.</p>
			<input type='button' name='confirm' class='confirm' value='Demo'/> or <a href='#' class='confirm'>Demo</a>
		</div>
		
		<!-- modal content -->
		<div id='confirm'>
			<div class='header'><span>Confirm</span></div>
			<div class='message'></div>
			<div class='buttons'>
				<div class='no simplemodal-close'>No</div><div class='yes'>Yes</div>
			</div>
		</div>
		<div style='display:none'>
			<img src='../img/confirm/header.gif' alt='' />
			<img src='../img/confirm/button.gif' alt='' />
		</div>
	</div>
	<div id='footer'>
		&copy; 2013 <a href='http://www.ericmmartin.com/'>Eric Martin</a><br/>
		<a href='https://github.com/ericmmartin/simplemodal'>SimpleModal on GitHub</a><br/>
		<a href='http://twitter.com/ericmmartin'>@ericmmartin</a> | <a href='http://twitter.com/simplemodal'>@simplemodal</a>
	</div>
    </div>
    </form>
    <script src="../js/jquery.js" type="text/javascript"></script>
    <script src="../js/jquery.simplemodal.js" type="text/javascript"></script>
    
<script src="../js/confirm.js" type="text/javascript"></script>
</body>
</html>
