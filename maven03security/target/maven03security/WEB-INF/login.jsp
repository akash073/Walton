<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib uri="http://www.springframework.org/tags/form" prefix="form" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
  <title>User Login.</title>
</head>
<body>
<h4>User Login.</h4>
<c:if test="${param.error != null}">
  <p>Invalid username / password</p>
</c:if>
<c:url var="loginUrl" value="/login"/>
<form action="${loginUrl}" method="post">
  <p><label for="username">User:</label></p>
  <input type="text" id="username" name="username"/>

  <p><label for="password">Password:</label></p>
  <input type="password" id="password" name="password">

  <div>
    <input name="submit" type="submit"/>
  </div>
</form>
</body>
</html>
