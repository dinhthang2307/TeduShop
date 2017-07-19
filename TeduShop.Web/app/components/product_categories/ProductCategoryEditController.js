(function (app) {
    app.controller('ProductCategoryEditController', ProductCategoryEditController);

    categoryEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', '$stateParams'];

    function ProductCategoryEditController() {
        $scope.productCategory = {

        }

        $scope.EditProductCategory = function () {
            apiService.put('api/productcategory/update', $scope.ProductCategory,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được cập nhật.');
                    $state.go('product_categories');
                }, function (error) {
                    notificationService.displayError('Cập nhật không thành công.');
                });
        }

        $scope.loadProductCategoryDetail = loadCategoryDetail;
        function loadCategoryDetail() {
            apiService.get('api/productcategory/getbyid/' + $stateParams.id, null, function (result) {
                $scope.ProductCategory = result.data;
            }), function (error) {
                notificationService.displayError(error.data);
            };
        }

        loadProductCategoryDetail();
    }
})(angular.module('tedushop.product_categories'));