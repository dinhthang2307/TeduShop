// <reference path="/Asserts/admin/libs/angular/angular.js" />

(function () {
    angular.module('tedushop.product_categories', ['tedushop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouteProvider) {
        $stateProvider.state('product_categories', {
            url: "/product_categories",
            templateUrl: "/app/components/product_categories/ProductCategoryListView.html",
            controller: "ProductCategoryListController"
        }).state('add_product_category', {
            url: "/add_product_category",
            templateUrl: "/app/components/product_categories/ProductCategoryAddView.html",
            controller: "ProductCategoryAddController"
            }).state('edit_product_category', {
                url: "/edit_product_category/:id",
                templateUrl: "/app/components/product_categories/ProductCategoryEditView.html",
                controller: "ProductCategoryEditController"
            });
    }
})();