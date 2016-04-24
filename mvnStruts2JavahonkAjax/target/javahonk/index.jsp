<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
         pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="s" uri="/struts-tags"%>
<?xml version="1.0" encoding="UTF-8" ?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <title>Struts 2 AJAX jQuery JSON example</title>
    <link rel="stylesheet"
          href="//code.jquery.com/ui/1.10.4/themes/smoothness/jquery-ui.css" />
    <script type="text/javascript"
            src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script src="//code.jquery.com/ui/1.10.4/jquery-ui.js"></script>
    <script type="text/javascript">

        function makeAjaxCall(){

            var firstName = $('#firstName').val();
            var lastName = $('#lastName').val();
            var location = $('#location').val();
            var json = {"firstName" : firstName,"lastName" : lastName,"location" : location};

            $.ajax({
                url: "jqueryAJAXAction"+"?jsonRequestdata="+JSON.stringify(json),
                type: 'POST',
                dataType: 'json',
                success:function(response){
                    console.log(response);
                    $('#firstName').val(response.firstName);
                    $('#lastName').val(response.lastName);
                    $('#location').val(response.location);
                    $('#ajax').text(response.firstName);
                },
                error:function(jqXhr, textStatus, errorThrown){
                    alert(textStatus);
                }
            });
        }

    </script>
    <s:head />
</head>

<body>
<h2 style="color: green">
    <s:text name="label.welcome" />
</h2>
<div>
<s:form action="" namespace="/" method="post"
        name="strutsForm">
    <s:textfield id="firstName" size="30" maxlength="50" label="First Name" value=""/>
    <s:textfield id="lastName" size="30" maxlength="50" label="Last Name" value=""/>
    <s:textfield id="location" size="30" maxlength="50" label="Location" value=""/>
    <s:submit type="button" label="Get Ajax data for server" onclick="makeAjaxCall();return false;"/>
</s:form>
</div>
<div >
    <label id="ajax"></label>
</div>
<div>
    <a href="http://javahonk.com/struts-2-ajax-jquery-json-example/">javahonk</a>
</div>
</body>
</html>