/// <reference path="../Services/memSignupService.js" />
/// <reference path="../app.js" />
ores.controller("memSignupCtrl", ["$scope", "$location", "memSignupService", function ($scope, $location, memSignupService) {

    $scope.member = {};

    $scope.saveMember = function () {
        memSignupService.memberSignup($scope.member).then(function (res) {
            if (res) {
                $location.path("/memlogin");
            }
        });
    };

    //$scope.oneAtATime = true;

    //$scope.groups = [
    //  {
    //      title: 'Dynamic Group Header - 1',
    //      content: 'Dynamic Group Body - 1'
    //  },
    //  {
    //      title: 'Dynamic Group Header - 2',
    //      content: 'Dynamic Group Body - 2'
    //  }
    //];

    //$scope.items = ['Item 1', 'Item 2', 'Item 3'];

    //$scope.addItem = function () {
    //    var newItemNo = $scope.items.length + 1;
    //    $scope.items.push('Item ' + newItemNo);
    //};

    //$scope.status = {
    //    isCustomHeaderOpen: false,
    //    isFirstOpen: true,
    //    isFirstDisabled: false
    //};
}]);