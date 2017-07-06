var HelloAngularApp = angular.module('HelloAngularApp', ['ngRoute']);

HelloAngularApp.controller('LandingPageController', LandingPageController);


var configFunction = function ($routeProvider) {
    $routeProvider.
        when('/electricity', {
            templateUrl: 'contracts/electricity'
        })
        .when('/heat', {
            templateUrl: 'contracts/heat'
        })
        ;
}
configFunction.$inject = ['$routeProvider'];

HelloAngularApp.config(configFunction);