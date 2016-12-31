/// <reference path="../app.js" />
ores.controller("indexController", ["$scope", "$http", "$location","mobileCheck", function ($scope,$http, $location, mobileCheck) {
    if (mobileCheck) {
        angular.element(document.querySelector("#bs-example-navbar-collapse-2")).removeClass("banner-right")
    }
    $scope.fnGoToPage = function (args) {
        $location.path('/' + args);
    }
}])