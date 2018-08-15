(function (app) {
    app.controller('ProductCategoryEditController', ProductCategoryEditController);

    ProductCategoryEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', '$stateParams','commonService'];

    function ProductCategoryEditController(apiService, $scope, notificationService, $state, $stateParams, commonService) {
        $scope.productCategory = {

        }

        $scope.GetSeoTitle = function () {
            $scope.productCategory.Alias = commonService.getSeoTitle($scope.productCategory.Name);
        };

        $scope.ckeditorOptions = {
            languague: 'vi',
            height: '200px'
        }

        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.productCategory.Image = fileUrl;
            }
            finder.popup();
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

        function loadParentCategory() {
            apiService.get('api/productcategory/getallparents', null, function (result) {
                $scope.parentCategories = result.data;
            }, function () {
                console.log('Cannot get list parent');
            });
        }
        loadParentCategory();

        loadProductCategoryDetail();
    }
})(angular.module('tedushop.product_categories'));