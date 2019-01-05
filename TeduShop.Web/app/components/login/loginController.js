(function (app) {
    app.controller('loginController', ['$scope', 'loginService', '$injector', 'notificationService', '$state',
        function ($scope, loginService, $injector, notificationService, $state) {

            $scope.loginData = {
                userName: "",
                password: ""
            };

            /* loginService.login($scope.loginData.userName, $scope.loginData.password).then(function( response) {
                if (response != null && response.error != undefined) {
                    notificationService.displayError("Đăng nhập không đúng.");
                }
                else {
                    console.log($scope.loginData.userName);
                    console.log($scope.loginData.password);
                    var stateService = $injector.get('$state');
                    stateService.go('home');
                }
            }); */
            $scope.loginSubmit = function () {
                $state.go('home');
            }
        }]);
})(angular.module('tedushop'));