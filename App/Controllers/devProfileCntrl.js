/// <reference path="../app.js" />
ores.controller("devProfileCntrl", ["$scope", "$location", "loginService", function ($scope, $location, loginService) {
    $scope.fnGoToPage = function (args) {
        $location.path('/' + args);
    };
}])