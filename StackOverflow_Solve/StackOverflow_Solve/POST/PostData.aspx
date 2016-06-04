<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostData.aspx.cs" Inherits="StackOverflow_Solve.POST.PostData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%--<form id="form1" runat="server">
    <div>
    ReceivePostData.aspx
    

    </div>
    </form>--%>
    <form method="POST" action="othersite.aspx" id="form1" runat="server">
      <fieldset>
        <dl>
          <dt>
            <label for="txtUserName">UserName</label>
          </dt>
          <dd>
            <input name="userName" type="text" id="UserName" class="fieldSignin"/>
          </dd>
          <dt>
            <label for="txtPassword">Password:</label>
          </dt>
          <dd>
            <input name="password" type="password" id="password" class="fieldSignin"/>
          </dd>
        </dl>
      </fieldset>
      <div class="formButtons">
        <input type="submit" name="login" value="Sign in" id="login" class="buttonPrimary" />
      </div>
      </form>
</body>
</html>
