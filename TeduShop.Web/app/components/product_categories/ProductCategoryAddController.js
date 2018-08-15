(function (app) {
    app.controller('ProductCategoryAddController', ProductCategoryAddController);

    ProductCategoryAddController.$inject = ['apiService', '$scope', 'notificationService', '$state', 'commonService'];

    function ProductCategoryAddController(apiService, $scope, notificationService, $state, commonService) {
        $scope.productCategory = {
            CreatedDate: new Date(),
            Status: true,
            Name:"Danh mục 1"
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


        $scope.AddProductCategory = function(){
            apiService.post('api/productcategory/create', $scope.productCategory,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được thêm mới.');
                    $state.go('product_categories');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
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