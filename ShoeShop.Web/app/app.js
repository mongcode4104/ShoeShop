/// <reference path="../assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('shoeshop',
        ['shoeshop.products',
         'shoeshop.product_categories',
         'shoeshop.common'])
        .config(config);

    config.$inject = ['$urlRouterProvider', '$stateProvider'];

    function config($urlRouterProvider, $stateProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();