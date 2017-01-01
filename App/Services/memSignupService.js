/// <reference path="../app.js" />
ores.factory("memSignupService", ["$http", "$q", "baseService", function ($http, $q, baseService) {

    var memSignupFactory = {};

    var memberSignup = function (member) {
        var deffer = $q.defer();
        $http.post(baseService + 'api/memberSignup/', JSON.stringify({ 'member': member }), {
            headers: { 'Content-Type': 'application/json;charset=utf-8' }
        }).success(function (data, status) {

            deffer.resolve(data, status);
        }).error(function (result, status) {
            deffer.reject(result);
        });
        return deffer.promise;
    };

    return memSignupFactory;

}]);