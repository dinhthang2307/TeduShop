(function (app) {
    app.controller('ProductCategoryAddController', ProductCategoryAddController);
    ProductCategoryAddController.$inject = ['apiService','$scope'];
    function ProductCategoryAddController(apiService, $scope) {
        $scope.productCategory = {
            CreatedDate: new Date(),
            Status:true
        }

        function loadParentCategory() {
            apiService.get('api/productcategory/getallparents', null, function (result) {

                $scope.parentCategories = result.data;

            }, function () {
                console.log('Cannot get list parent');
            });
        }
        loadParentCategory();
    }
})(angular.module('tedushop.product_categories'));