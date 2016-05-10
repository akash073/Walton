<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PopulateDataAfterButtonClick.aspx.cs" Inherits="StackOverflow_Solve.AngularJS.PopulateDataAfterButtonClick" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.5/angular.min.js"
        type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div ng-app="MyApp">
    <div ng-controller="Main">
        <form name="myForm">
            <input type="email" ng-model="rootFolders">
            <button type="submit">Submit</button>
        </form> <span ng-repeat="user in users" style="float:left">
            {{user.name}}<br>
            <button ng-click="loadEmail(user);">Load Email</button>
        </span>
    </div>
</div>
    </div>
    <script>
        angular.module('MyApp', []);

        function Main($scope) {
            $scope.rootFolders = 'bob@go.com';
            $scope.users = [{
                    id: 0,
                    name: 'user1',
                    login: 'user1@go.com',
                    password: '123456'
                }, {
                    id: 1,
                    name: 'user2',
                    login: 'user2@go.com',
                    password: '123456'
                },];

            $scope.loadEmail = function(user) {
                $scope.rootFolders = user.login;
            };
        }
    </script>
    </form>
</body>
</html>
