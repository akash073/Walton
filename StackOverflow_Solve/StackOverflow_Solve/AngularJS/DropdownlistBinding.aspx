<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropdownlistBinding.aspx.cs"
    Inherits="StackOverflow_Solve.AngularJS.DropdownlistBinding" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="angular.min.js" type="text/javascript"></script>
</head>
<body ng-app="myApp">
    <form id="form1" runat="server">
    <div>
        <div>
            <select>
                <option value="volvo">Volvo</option>
                <option value="saab">Saab</option>
                <option value="mercedes">Mercedes</option>
                <option value="audi">Audi</option>
            </select>
        </div>
        <div ng-controller="dropdownListCtrl">
            <select>
                <option ng-repeat="item in items" value="{{item.Id}}">{{item.ItemName}}</option>
            </select>
            <br />
            <select name="name" id="id" ng-model="items" ng-options="size as size.name for item in items"
                class="form-control" ng-change="update()">
            </select>
        </div>
        <div ng-controller="selectController">
            <select name="category-group" id="categoryGroup" class="form-control" ng-model="itemSelected"
                ng-change="onCategoryChange(itemSelected)" ng-options="category.name group by category.group for category in categories">
            </select>
        </div>
    </div>
    </form>
    <script>
        var app = angular.module('myApp', []);
        app.controller('selectController', ['$scope', '$window', function ($scope, $window) {
    
    

    $scope.categories = [       
      { id: 0, name: "Select a category..."},
        { id: 1, name: "Cars", group : "- Vehicles -" },
       { id: 2, name: "Commercial vehicles", disabled: false,group : "- Vehicles -" },
       { id: 3, name: "Motorcycles", disabled: false, group : "- Vehicles -"  },
       { id: 4, name: "Car & Motorcycle Equipment", disabled: false,
       group : "- Vehicles -" },
       { id: 5, name: "Boats", disabled: false, group : "- Vehicles -"  },
       { id: 6, name: "Other Vehicles", disabled: false, group : "- Vehicles -"  },
       { id: 7, name: "Appliances", disabled: false , group : "- House and Children -" },
       { id: 8, name: "Inside", disabled: false,group : "- House and Children -"  },
       { id: 9, name: "Games and Clothing", disabled: false,group : "- House and Children -"  },
       { id: 10, name: "Garden", disabled: false,group : "- House and Children -"  }
    ];
    
    //$scope.itemSelected = $scope.categories[0];

    $scope.onCategoryChange = function () {

        $window.alert("Selected Value: " + $scope.itemSelected.id + "\nSelected Text: " + $scope.itemSelected.name);

    };

}]);
        app.controller('dropdownListCtrl', function ($scope, $http) {
            // Posting data to php file
            $http({
                method: 'GET',
                url: 'http://localhost:1611/Services/SpareInfos.asmx/GetDropDownListBindings',
               // data: { 'id': 1 }, //forms user object
              //  headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            })
          .success(function (data) {
              
              $scope.items = data;
          });
            $scope.update = function() {
                console.log($scope.selectedItem);
                $scope.item.size.code = $scope.selectedItem.code;
                // use $scope.selectedItem.code and $scope.selectedItem.name here
                // for other stuff ...
            };          
           

        });
    </script>
</body>
</html>
