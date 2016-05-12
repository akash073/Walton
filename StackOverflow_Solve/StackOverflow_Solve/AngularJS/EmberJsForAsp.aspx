<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmberJsForAsp.aspx.cs"
    Inherits="StackOverflow_Solve.EMBERjs.EmberJsForAsp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.5/angular.min.js"
        type="text/javascript"></script>
</head>
<body ng-app="myApp">
    <form id="form1" runat="server">
    
    <br/>
    <div ng-controller="TestCtrl">
        <button ng-click="clicked($event)">
            Click me!</button>
    </div>
    <div ng-controller="myCtrl">
        <p>
            Input something in the input box:</p>
        <p>
            Name:
            <input type="text" ng-model="name"></p>
        <p ng-bind="name">
        </p>
        <div id="divID"></div>
        <div>
            <p>
                Looping with ng-repeat:</p>
            <ul>
                <li ng-repeat="x in message">{{ x.ItemName }} </li>
            </ul>
        </div>
    </div>
    </form>
    <script src="angularJs.js" type="text/javascript"></script>
    <script>
       
    
    </script>
</body>
</html>
