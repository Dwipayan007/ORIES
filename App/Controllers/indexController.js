/// <reference path="../app.js" />
ores.controller("indexController", ["$scope", "mobileCheck", function ($scope, mobileCheck) {
    if (mobileCheck) {
        angular.element(document.querySelector("#bs-example-navbar-collapse-2")).removeClass("banner-right")
    }
}])