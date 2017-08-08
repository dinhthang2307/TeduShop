(function (app) {
    app.controller('productAddController', productAddController);
    productAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];
    function productAddController(apiService, $scope, notificationService, $state) {
        $scope.product = {
            CreatedDate: new Date(),
            Status: true
        }

        $scope.ckeditorOptions = {
            language: 'vi',
            height: '200px'
        }

        $scope.AddProduct = function () {
            apiService.post('api/product/create', $scope.product,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được thêm mới.');
                    $state.go('product_categories');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }

        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.product.Image = fileUrl;
            }
            finder.popup();
        }


        function loadProductCategory() {
            apiService.get('api/productcategory/getallparents', null, function (result) {
                $scope.parentCategories = result.data;
            }, function () {
                console.log('Cannot get list parent');
            });
        }
        loadProductCategory();
    }
})(angular.module('tedushop.products'));