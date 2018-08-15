(function (app) {
    app.controller('productEditController', productEditController);

    productEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', '$stateParams', 'commonService'];

    function productEditController(apiService, $scope, notificationService, $state, $stateParams, commonService) {
        $scope.product = {

        }

        $scope.GetSeoTitle = function () {
            $scope.product.Alias = commonService.getSeoTitle($scope.product.Name);
        };

        $scope.ckeditorOptions = {
            languague: 'vi',
            height: '200px'
        }

        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.product.Image = fileUrl;
            }
            finder.popup();
        }

        $scope.editProduct = function () {
            apiService.put('api/product/update', $scope.product,
                function (result) {
                    notificationService.displaySuccess($scope.product.Name + ' đã được cập nhật.');
                    $state.go('products');
                }, function (error) {
                    notificationService.displayError('Cập nhật không thành công.');
                });
        }

        $scope.loadProductDetail = loadProductDetail;
        function loadProductDetail() {
            apiService.get('api/product/getbyid/' + $stateParams.id, null, function (result) {
                $scope.product = result.data;
            }), function (error) {
                notificationService.displayError(error.data);
            };
        }

        function loadProductCategory() {
            apiService.get('api/productcategory/getallparents', null, function (result) {
                $scope.productCategories = result.data;
            }, function () {
                console.log('Cannot get list parent');
            });
        }
        loadProductCategory();

        loadProductDetail();
    }
})(angular.module('tedushop.products'));