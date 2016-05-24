<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOfItemsByAngularJSAjaxNgRepeat.aspx.cs"
    Inherits="StackOverflow_Solve.AngularJS.ListOfItemsByAngularJSAjaxNgRepeat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" ng-app="myApp">
<head runat="server">
    <title></title>
    <script src="angular.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div ng-controller="myCtrl">
        <ul>
            <%--<li ng-repeat="item in items" ng-click="clickMe(item,$event)">{{item.Name }}</li>--%>
            <li ng-repeat="item in items" ><button id="{{item.Id}}" ng-click="clickMe(item,$event)">{{item.Name}}</button></li>
        </ul>
    </div>
    </form>
    <script>
        var app = angular.module('myApp', []);
        app.controller('myCtrl', function ($scope, $http) {
            // Posting data to php file
            $http({
                method: 'POST',
                url: 'ListOfItemsByAngularJSAjaxNgRepeat.aspx/GetItemList',
                data: { 'id': 1 }, //forms user object
              //  headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            })
          .success(function (data) {
              console.log(data);
              $scope.items = data.d;
          });
          
           $scope.clickMe = function (item,event) {
                event.preventDefault();
                console.log(item.Id);
//                $http({
//                method: 'POST',
//                url: 'ListOfItemsByAngularJSAjaxNgRepeat.aspx/RemoveItemList',
//                data: { 'id': item.Id }, //forms user object
//              //  headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
//            })
//          .success(function (data) {
//              console.log(data);
//              $scope.items = data.d;
//          });
            };

        });
           
    </script>
</body>
</html>
