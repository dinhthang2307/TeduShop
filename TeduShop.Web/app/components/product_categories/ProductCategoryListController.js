(function (app) {
    app.controller('ProductCategoryListController', ProductCategoryListController);

    ProductCategoryListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function ProductCategoryListController($scope, apiService, notificationService, $ngBootbox) {
        $scope.productCategories = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.getProductCategories = getProductCategories;
        $scope.keyWord = '';
        $scope.deleteProductCategory = deleteProductCategory;       
        $scope.search = search;
        function search() {
            getProductCategories();
        }

        function deleteProductCategory(id) {
            $ngBootbox.confirm('Bạn có chắc muốn xóa?').then(function () {
                var config = {
                    params: {
                        id : id
                    }
                }

                apiService.del('api/productcategory/delete', config, function () {
                    notificationService.displaySuccess('Xóa thành công');
                    search();
                }),
                function () {
                    notificationService.displayError('Xóa không thành công');
                }
            });
        }

        function getProductCategories(page) {
            page = page || 0;
            var config = {
                params: {
                    keyWord:$scope.keyWord,
                    page: page,
                    pageSize:20
                }
            }
            apiService.get('/api/productcategory/getall', config, function (result) {
                if (result.data.TotalCount == 0) {
                    notificationService.displayWarning('Không có bản ghi nào được tìm thấy.');
                }
                else {
                    notificationService.displaySuccess('Đã tìm thấy '+result.data.TotalCount+' bản ghi');

                }
                $scope.productCategories = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pagesCount = result.data.TotalPages;
                $scope.totalCount = result.data.TotalCount;
            }, function () {
                console.log('Load productcategory failed.');
            });
        }

        $scope.getProductCategories();
    }
})(angular.module('tedushop.product_categories'));