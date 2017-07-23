(function (app) {
    app.controller('ProductCategoryEditController', ProductCategoryEditController);

    ProductCategoryEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', '$stateParams'];

    function ProductCategoryEditController(apiService, $scope, notificationService, $state, $stateParams) {
        $scope.productCategory = {

        }

        $scope.editProductCategory = function () {
            apiService.put('api/productcategory/update', $scope.productCategory,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được cập nhật.');
                    $state.go('product_categories');
                }, function (error) {
                    notificationService.displayError('Cập nhật không thành công.');
                });
        }

        $scope.loadProductCategoryDetail = loadProductCategoryDetail;
        function loadProductCategoryDetail() {
            apiService.get('api/productcategory/getbyid/' + $stateParams.id, null, function (result) {
                $scope.productCategory = result.data;
            }), function (error) {
                notificationService.displayError(error.data);
            };
        }

        loadProductCategoryDetail();
    }
})(angular.module('tedushop.product_categories'));