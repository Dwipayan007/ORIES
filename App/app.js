/// <reference path="F:\Typescript\Ores\Ores\Scripts/angular-route.js" />
/// <reference path="F:\Typescript\Ores\Ores\Scripts/angular.js" />
var ores = angular.module("ores", ["ngRoute"]);
ores.config(function ($routeProvider) {
    $routeProvider.when("/home", {
        controller: "homeController",
        templateUrl: "App/Views/home.html"
    }).otherwise({ redirectTo: "/home" });
});