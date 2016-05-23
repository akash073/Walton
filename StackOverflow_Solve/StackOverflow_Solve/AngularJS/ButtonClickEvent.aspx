<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonClickEvent.aspx.cs"
    Inherits="StackOverflow_Solve.AngularJS.ButtonClickEvent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="angular.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div ng-app="myApp">
        <div ng-controller="myCtrl">
            <asp:Button ID="btnClick" runat="server" Text="clickMe" ng-click="calculateQuantity($event)" />
        </div>
        <div id="customerProductCatalogText" ng-controller="myCtrl">
            <button id="test" ng-click="clickMe(item,$event)"> click</button><br />
        </div>
        <div ng-controller="MyController">
            

            <ul>
                <li ng-repeat="item in myData.items" ng-click="myData.doClick(item, $event)">{{item.v}}</li>
            </ul>
        </div><%--ngrepeat can pass data to click event--%>
    </div>
    <script>
        var app = angular.module('myApp', []);
        app.controller('myCtrl', function ($scope) {
            $scope.clickMe = function (item,event) {
                event.preventDefault();
                console.log(item);
            };
            $scope.calculateQuantity = function (event) {
                event.preventDefault();
                console.log(event.target.id);

                angular.element(document.querySelector('#customerProductCatalogText')).append('');
            };
        });
        app.controller("MyController", function ($scope) {
            $scope.myData = {};
            $scope.myData.items = [{ v: "1" }, { v: "2" }, { v: "3"}];

            $scope.myData.doClick = function (item, event) {
                console.log(item);
                alert("clicked: " + item.v + " @ " + event.clientX + ": " + event.clientY);
            };


        });
    </script>
    </form>
</body>
</html>
