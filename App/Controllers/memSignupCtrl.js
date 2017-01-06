/// <reference path="../Services/memSignupService.js" />
/// <reference path="../app.js" />
ores.controller("memSignupCtrl", ["$scope", "$location", "memSignupService", function ($scope, $location, memSignupService) {
    $scope.member = {};
    $scope.member.userType = "M";
    $scope.Category = [{ "cid": "1", "category": "Plese Select" }, { "cid": "2", "category": "Founder Members" }, { "cid": "3", "category": "Patron Members" }, { "cid": "4", "category": "Associate Members" }, { "cid": "5", "category": "Regular Members" }];
    $scope.categoryData = $scope.Category[0];
    $scope.changeRelated = function () {
        debugger;
        $scope.categorySel = $scope.categoryData.category;
        $scope.member.category = $scope.categorySel;
    };

    $scope.priceRang = [{ "pid": "1", "prang": "Plese Select" }, { "pid": "2", "prang": "Rs 1lac" }, { "pid": "3", "prang": "Rs. 50,000/-" }, { "pid": "4", "prang": ">Rs 25,000/-" }, { "pid": "5", "prang": "Rs 1,250/-" }];
    $scope.priceRangData = $scope.priceRang[0];
    $scope.changepriceRang = function () {
        debugger;
        $scope.prangSel = $scope.priceRangData.prang;
        $scope.member.prang = $scope.prangSel;
    };
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