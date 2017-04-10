(function (app) {
    app.controller('ProductCategoryListController', ProductCategoryListController);

    ProductCategoryListController.$inject = ['$scope', 'apiService', 'notificationService'];

    function ProductCategoryListController($scope, apiService, notificationService) {
        $scope.productCategories = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.getProductCategories = getProductCategories;
        $scope.keyWord ='';
       
        $scope.search = function search() {
            getProductCategories();
        }

        function getProductCategories( page) {
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