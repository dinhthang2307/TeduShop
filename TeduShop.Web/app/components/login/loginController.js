(function (app) {
    app.controller('loginController', ['$scope', 'loginService', '$injector', 'notificationService', '$state', 'authenticationService',
        function ($scope, loginService, $injector, notificationService, $state,  authenticationService) {

            $scope.loginData = {
                userName: "",
                password: ""
            };

            // click login button
            $scope.loginSubmit = function () {
                // call login service
                loginService.login($scope.loginData.userName, $scope.loginData.password).then(function (response) {
                    // new co response tra ve va co loi
                    if (response != null && response.error != undefined) {
                        notificationService.displayError("Đăng nhập không đúng.");
                    }
                    // dang nhap thanh cong
                    else {
                        console.log($scope.loginData.userName);
                        console.log(authenticationService.getTokenInfo());
                        var stateService = $injector.get('$state');
                        stateService.go('home');
                    }
                });
            }
        }]);
})(angular.module('tedushop'));