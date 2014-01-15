if ($(".person-create").length) {
    // Call setup method before initializing Angular:
    setupRazoringModel();

    var razoriNgModelDemoApp = angular.module("RazoriNgModelDemo", []);

    // Rest of your Angular code here.

    razoriNgModelDemoApp.controller("PeopleController", function ($scope) {
        $scope.people = [];
        $scope.person = {};
    });
}