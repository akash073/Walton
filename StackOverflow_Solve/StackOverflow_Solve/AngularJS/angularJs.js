var app = angular.module('myApp', []);
app.controller('myCtrl', function ($scope, $http) {

});
app.controller('TestCtrl', ['$scope', '$http', '$controller', function ($scope, $http, $controller) {

    $scope.clicked = function (event) {
        alert("Clicked");
        event.preventDefault();

        console.log($controller);
        var yourUrl = "EmberJsForAsp.aspx/ajaxcall";
        var postData = {};
        postData.text = "akash";
        var res = $http.post(yourUrl, postData);
        res.success(function (result, status, headers, config) {
            console.log(result.d.length);
            var data = result.hasOwnProperty('d') ? result.d : result;
            $scope.message = data;
            for (var i = 0; i < data.length; i++) {
                var myEl = angular.element(document.querySelector('#divID'));
                myEl.append('This is text. Here html tags will be displayed like normal tags. Example : <span style="font-weight:bold;"> Styled Text</span><br/>');
            }

        });
        res.error(function (data, status, headers, config) {
            console.log(data);
            return false;
            //alert( "failure message: " + JSON.stringify({data: data}));
        });
    };
} ]);